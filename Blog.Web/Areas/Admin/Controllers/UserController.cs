using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.DTOs.Users;
using Blog.Entity.Entities;
using Blog.Entity.Enums;
using Blog.Service.Extensions;
using Blog.Service.Helpers.Images;
using Blog.Web.ResultMessages;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System.Data;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly RoleManager<AppRole> roleManager;
        private readonly IMapper mapper;
        private readonly IToastNotification toast;
        private readonly IValidator<AppUser> validator;
        private readonly IImageHelper ımageHelper;
        private readonly IUnitOfWork unitOfWork;

        public UserController(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager ,RoleManager<AppRole> roleManager, IMapper mapper, IToastNotification toast, IValidator<AppUser> validator, IImageHelper ımageHelper, IUnitOfWork unitOfWork)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.mapper = mapper;
            this.toast = toast;
            this.validator = validator;
            this.ımageHelper = ımageHelper;
            this.unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var users = await userManager.Users.ToListAsync();
            var map = mapper.Map<List<UserDto>>(users);

            foreach (var item in map)
            {
                var findUser = await userManager.FindByIdAsync(item.Id.ToString());
                var role = string.Join("", await userManager.GetRolesAsync(findUser));

                item.Role = role;
            }

            return View(map);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var roles = await roleManager.Roles.ToListAsync();
            return View(new UserAddDto { Roles = roles });
        }
        [HttpPost]
        public async Task<IActionResult> Add(UserAddDto userAddDto)
        {
            var map = mapper.Map<AppUser>(userAddDto);
            var validation = await validator.ValidateAsync(map);
            var roles = await roleManager.Roles.ToListAsync();

            if (ModelState.IsValid)
            {
                map.UserName = userAddDto.Email;
                var result = await userManager.CreateAsync(map, string.IsNullOrEmpty(userAddDto.Password) ? "" : userAddDto.Password);
                if (result.Succeeded)
                {
                    var findRole = await roleManager.FindByIdAsync(userAddDto.RoleId.ToString());
                    await userManager.AddToRoleAsync(map, findRole.ToString());
                    toast.AddSuccessToastMessage(Messages.User.Add(userAddDto.Email), new ToastrOptions { Title = "Başarılı" });
                    return RedirectToAction("Index", "User", new { Area = "Admin" });
                }
                else
                {


                    result.AddToIdentityModelState(this.ModelState);
                    validation.AddToModelStates(ModelState);
                    return View(new UserAddDto { Roles = roles });

                }
            }
            return View(new UserAddDto { Roles = roles });

        }
        [HttpGet]
        public async Task<IActionResult> Update(Guid userId)
        {
            var user = await userManager.FindByIdAsync(userId.ToString());

            var roles = await roleManager.Roles.ToListAsync();

            var map = mapper.Map<UserUpdateDto>(user);
            map.Roles = roles;
            return View(map);

        }
        [HttpPost]
        public async Task<IActionResult> Update(UserUpdateDto userUpdateDto)
        {
            var user = await userManager.FindByIdAsync(userUpdateDto.Id.ToString());
            if (user != null)
            {
                var userRole = string.Join("", await userManager.GetRolesAsync(user));
                var roles = await roleManager.Roles.ToListAsync();
                if (ModelState.IsValid)
                {
                    var map = mapper.Map(userUpdateDto, user);
                    var validation = await validator.ValidateAsync(map);
                    if (validation.IsValid)
                    {
                        user.UserName = userUpdateDto.Email;
                        user.SecurityStamp = Guid.NewGuid().ToString();
                        var result = await userManager.UpdateAsync(user);
                        if (result.Succeeded)
                        {
                            await userManager.RemoveFromRoleAsync(user, userRole);
                            var findRole = await roleManager.FindByIdAsync(userUpdateDto.RoleId.ToString());
                            await userManager.AddToRoleAsync(user, findRole.Name);
                            toast.AddSuccessToastMessage(Messages.User.Update(userUpdateDto.Email), new ToastrOptions { Title = "Başarılı" });
                            return RedirectToAction("Index", "User", new { Area = "Admin" });
                        }
                        else
                        {
                            result.AddToIdentityModelState(this.ModelState);

                            return View(new UserUpdateDto { Roles = roles });
                        }
                    }
                    else
                    {
                        validation.AddToModelStates(this.ModelState);

                        return View(new UserUpdateDto { Roles = roles });

                    }



                }
            }
            return NotFound();
        }
        public async Task<IActionResult> Delete(Guid userId)
        {
            var user = await userManager.FindByIdAsync(userId.ToString());
            if (user != null)
            {
                var result = await userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    toast.AddSuccessToastMessage(Messages.User.SafeDelete(user.Email), new ToastrOptions { Title = "Başarılı" });
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return NotFound();

        }
        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            var getImage = await unitOfWork.GetRepository<AppUser>().GetAsync(x=>x.Id == user.Id,x=>x.Image);
            var map = mapper.Map<UserProfileDto>(user);
            map.Image.FileName = getImage.Image.FileName;
            return View(map);
        }
        [HttpPost]
        public async Task<IActionResult> Profile(UserProfileDto userProfileDto)
        {
            var user = await userManager.GetUserAsync(HttpContext.User);
            if (ModelState.IsValid)
            {
                var IsVerifed = await userManager.CheckPasswordAsync(user, userProfileDto.CurrentPassword);
                if(IsVerifed && userProfileDto.NewPassword != null && userProfileDto.Photo != null)
                {
                    var result = await userManager.ChangePasswordAsync(user,userProfileDto.CurrentPassword,userProfileDto.NewPassword);
                    if(result.Succeeded)
                    {
                        await userManager.UpdateSecurityStampAsync(user);
                        await signInManager.SignOutAsync();
                        await signInManager.PasswordSignInAsync(user, userProfileDto.NewPassword, true, false);

                        user.FirstName = userProfileDto.FirstName;
                        user.LastName = userProfileDto.LastName;
                        user.Email = userProfileDto.Email;
                        user.PhoneNumber = userProfileDto.PhoneNumber;

                        var imageUpload = await ımageHelper.Upload($"{userProfileDto.FirstName}{userProfileDto.LastName}", userProfileDto.Photo, ImageType.User);
                        Image image = new(imageUpload.FullName, userProfileDto.Photo.ContentType, user.Email);
                        await unitOfWork.GetRepository<Image>().AddAsync(image);

                        user.ImageId = image.Id;

                        await userManager.UpdateAsync(user);

                        await unitOfWork.SaveAsync();

                        toast.AddSuccessToastMessage("Şifreniz ve bilgileriniz başarıyla gerçekleşmiştir!");
                        return View();
                    }
                    else
                    {
                        result.AddToIdentityModelState(ModelState);
                        return View();
                    }
                }
                else if(IsVerifed && userProfileDto.Photo != null)
                {
                    await userManager.UpdateSecurityStampAsync(user);
                    user.FirstName = userProfileDto.FirstName;
                    user.LastName = userProfileDto.LastName;
                    user.Email = userProfileDto.Email;
                    user.PhoneNumber = userProfileDto.PhoneNumber;

                    var imageUpload = await ımageHelper.Upload($"{userProfileDto.FirstName}{userProfileDto.LastName}", userProfileDto.Photo, ImageType.User);
                    Image image = new(imageUpload.FullName, userProfileDto.Photo.ContentType, user.Email);
                    await unitOfWork.GetRepository<Image>().AddAsync(image);

                    user.ImageId = image.Id;

                    await userManager.UpdateAsync(user);

                    await unitOfWork.SaveAsync();

                    toast.AddSuccessToastMessage("Bilgileriniz başarıyla gerçekleşmiştir!");
                    return View();
                }
                else
                {
                    toast.AddErrorToastMessage("Bilgileriniz güncellenirken bir hata oluştu!");
                    return View();

                }

            }
            return View();

        }

    }
}
