using BlogSphere.Domain.Models;
using BlogSphere.Domain.ValueObjects.Article;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Abstractions.Repositories
{
    public interface IArticleRepository
    {
        Task<Article> GetById(ArticleId id);
        Task<IEnumerable<Article>> GetAllAsync(int pageNumber, int size);
        Task InsertAsync(Article article);
        Task UpdateAsync(Article article);
        Task DeleteAsync(Article article);

        Task<bool> SlugExistsAsync(string slug);

        Task InsertArticleTagsAsync(ArticleId id, List<Tag> tags);
        Task<List<Tag>> GetArticleTagsAsync(ArticleId id);
        Task DeleteArticleTags(ArticleId id);

        Task InsertArticleCommentsAsync(ArticleId id, List<Comment> comments);
        Task<List<Comment>> GetArticleCommentsAsync(ArticleId id);
        Task DeleteArticleComments(ArticleId id);

    }
}
