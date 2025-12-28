using BlogSphere.Domain.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Application.Articles
{
    public class ArticleService(IArticleRepository articleRepository) : IArticleService
    {
        public IArticleRepository ArticleRepository { get; } = articleRepository;

        public async Task<List<Article>> GetArticles()
        {
            return await ArticleRepository.GetAllArticlesAsync();
        }
    }
}
