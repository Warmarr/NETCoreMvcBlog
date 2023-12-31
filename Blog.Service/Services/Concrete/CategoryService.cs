﻿using AutoMapper;
using Blog.Data.UnitOfWorks;
using Blog.Entity.DTOs.Categories;
using Blog.Entity.Entities;
using Blog.Service.Extensions;
using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ClaimsPrincipal _user;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper,IHttpContextAccessor httpContextAccessor)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
        }

        public async Task<List<CategoryDto>> GetAllCategoriesNonDeleted()
        {
            var categories = await unitOfWork.GetRepository<Category>().GetAllAsync(x => !x.IsDeleted);
            var map = mapper.Map<List<CategoryDto>>(categories);

            return map;
        }
        public async Task<List<CategoryDto>> GetAllCategoriesNonDeletedTake20()
        {
            var categories = await unitOfWork.GetRepository<Category>().GetAllAsync(x => !x.IsDeleted);
            var map = mapper.Map<List<CategoryDto>>(categories);

            return map.Take(20).ToList();
        }
        public async Task<Category> GetCategoryByGuid(Guid categoryId)
        {
            var category = await unitOfWork.GetRepository<Category>().GetByGuidAsync(categoryId);
            return category;
        }
        public async Task CreateCategoryAsync(CategoryAddDto categoryAddDto)
        {
            var user = _user.GetLoggedInUserId();
            var email = _user.GetLoggedInEmail();

            Category category = new(categoryAddDto.Name,email);
            await unitOfWork.GetRepository<Category>().AddAsync(category);
            await unitOfWork.SaveAsync();

        }
        public async Task<string> UpdateCategoryAsync(CategoryUpdateDto categoryUpdateDto)
        {
            var usermail = _user.GetLoggedInEmail();
            var category = await unitOfWork.GetRepository<Category>().GetAsync(x => !x.IsDeleted && x.Id == categoryUpdateDto.Id);

            category.Name = categoryUpdateDto.Name;
            category.ModifiedBy = usermail;
            category.ModifiedDate = DateTime.Now;

            await unitOfWork.GetRepository<Category>().UpdateAsync(category);
            await unitOfWork.SaveAsync();

            return category.Name;
        }
        public async Task<string> SafeDeletCategoryAsync(Guid categoryId)
        {
            var usermail = _user.GetLoggedInEmail();
            var category = await unitOfWork.GetRepository<Category>().GetByGuidAsync(categoryId);

            category.IsDeleted = true;
            category.DeletedBy = usermail;
            category.DeletedDate = DateTime.Now;

            await unitOfWork.GetRepository<Category>().UpdateAsync(category);
            await unitOfWork.SaveAsync();

            return category.Name;
        }

        public async Task<List<CategoryDto>> GetAllCategegoriesWithDeletedAsync()
        {
            var categories = await unitOfWork.GetRepository<Category>().GetAllAsync(x=>x.IsDeleted);
            var map = mapper.Map<List<CategoryDto>>(categories);

            return map;
        }

        public async Task<string> UndoDeleteCategoryAsync(Guid categoryId)
        {
            var usermail = _user.GetLoggedInEmail();
            var category = await unitOfWork.GetRepository<Category>().GetByGuidAsync(categoryId);
            category.IsDeleted = false;
            category.DeletedDate = null;
            category.DeletedBy = null;

            await unitOfWork.GetRepository<Category>().UpdateAsync(category);
            await unitOfWork.SaveAsync();

            return category.Name;
        }
    }
}
