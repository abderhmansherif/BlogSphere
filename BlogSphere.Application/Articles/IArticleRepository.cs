using BlogSphere.Domain.Articles;

namespace BlogSphere.Application.Articles
{
    public interface IArticleRepository
    {
        Task<List<Article>> GetAllArticlesAsync();
    }
}
