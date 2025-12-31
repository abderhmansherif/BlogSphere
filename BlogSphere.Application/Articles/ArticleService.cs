using BlogSphere.Domain.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Application.Articles
{
    public class ArticleService(IArticleRepository articleRepository) : IArticleService
    {
        public IArticleRepository ArticleRepository { get; } = articleRepository;

        private List<ArticleViewModel> articles = new List<ArticleViewModel>()
        {
            new ArticleViewModel()
            {
                Id = 1,
                Title = "Article 1",
                Content = "This is Article 1",
                AuthorId = 1,
                CoverImage = "/images/test1.jpg",
                Likes = 12,
                Views = 120,
                ReadTime = 5,
                PublishedAt = DateTime.UtcNow.AddMonths(-1),
                Tags = new List<string>(){"Programming", ".NET Core", "Blazor"}
            },
            new ArticleViewModel()
            {
                Id = 2,
                Title = "Article 2",
                Content = "This is Article 2",
                CoverImage = "/images/test2.jpg",
                AuthorId = 1,
                Likes = 90,
                Views = 300,
                ReadTime = 5,
                PublishedAt = DateTime.UtcNow.AddMonths(-1),
                Tags = new List<string>(){"Programming", "Spring Boot", "Java"}
            },
        };
        public async Task<ArticleViewModel> GetArticleByIdAsync(int id)
        {
            return articles.First(x => x.Id == id);
        }

        public async Task<List<ArticleViewModel>> GetArticlesAsync()
        {
            return articles;
        }
    }
}
