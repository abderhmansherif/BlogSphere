using BlogSphere.Domain.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Application.Articles
{
    public class ArticleService : IArticleService
    {
        public List<Article> GetArticles()
        {
            return new List<Article>()
            {
                new Article()
                {
                    Id = 1,
                    Title = "Article 1",
                    Content = "This is Article 1"
                },
                new Article()
                {
                    Id = 2,
                    Title = "Article 2",
                    Content = "This is Article 2"
                },new Article()
                {
                    Id = 3,
                    Title = "Article 3",
                    Content = "This is Article 3"
                },
            };
        }


    }
}
