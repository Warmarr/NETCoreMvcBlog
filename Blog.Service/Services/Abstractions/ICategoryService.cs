﻿using Blog.Entity.DTOs.Categories;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstractions
{
    public interface ICategoryService
    {
        public Task<List<CategoryDto>> GetAllCategoriesNonDeleted();

        Task<Category> GetCategoryByGuid(Guid categoryId);
        public Task CreateCategoryAsync(CategoryAddDto categoryAddDto);
        Task<string> UpdateCategoryAsync(CategoryUpdateDto categoryUpdateDto);
        Task<string> SafeDeletCategoryAsync(Guid categoryId);

    }
}
