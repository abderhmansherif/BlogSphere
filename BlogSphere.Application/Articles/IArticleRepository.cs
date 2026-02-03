using BlogSphere.Domain.Models;

namespace BlogSphere.Application.Articles
{
    public interface IArticleRepository
    {
        Task<List<Article>> GetAllArticlesAsync();
    }
}
