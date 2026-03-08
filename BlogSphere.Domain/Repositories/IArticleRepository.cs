using BlogSphere.Domain.Entities;
using BlogSphere.Domain.ValueObjects.Article;


namespace BlogSphere.Domain.Repositories
{
    public interface IArticleRepository
    {
        Task<Article> GetAsync(ArticleTitle articleTitle);
        Task InsertAsync(Article article);
        Task UpdateAsync(Article article);
        Task DeleteAsync(Article article);
    }
}
