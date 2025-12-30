using BlogSphere.Domain.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Application.Articles
{
    public interface IArticleService
    {
        Task<List<ArticleViewModel>> GetArticles();
        Task<ArticleViewModel> GetArticleById(int id);
    }
}
