using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticleWithNonDeletedAsync();
        Task<List<ArticleDto>> GetAllArticlesWithArticlesDeletedAsync();
        Task<ArticleDto> GetArticleWithCategoryNonDeletedAsync(Guid articleId);
        Task<string> UpdateArticleAsync(ArticleUpdateDto articleUpdateDto);
        Task CreateArticleAsync(ArticleAddDto articleAddDto);
        Task<string> SafeDeleteArticleAsync(Guid articleId);
        Task<string> UndoDeleteArticleAsync(Guid articleId);
        Task<ArticleListDto> GetAllByPaggingAsync(Guid? categoryId, int currentPage = 1, int pageSize = 3, bool isAscending = false);
    }
}
