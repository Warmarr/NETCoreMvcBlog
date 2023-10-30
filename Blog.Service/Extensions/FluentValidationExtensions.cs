using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Blog.Service.Extensions
{
    public static class FluentValidationExtensions 
    {
        public static void AddToModelStates(this ValidationResult result, ModelStateDictionary modelState)
        {
            foreach(var errors in result.Errors)
            {
                modelState.AddModelError(errors.PropertyName,errors.ErrorMessage);
            }
        }
        public static void AddToIdentityModelState(this IdentityResult result, ModelStateDictionary modelState)
        {
            foreach (var errors in result.Errors)
            {
                modelState.AddModelError("", errors.Description);
            }
        }
    }
}
