using BlogSphere.Domain.Abstractions.Domain;
using BlogSphere.Domain.Enums;
using BlogSphere.Domain.Models;
using BlogSphere.Domain.ValueObjects.Article;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Factories
{
    public class ArticleFactory : IArticleFactory
    {
   
        public Article CreateDDraft(ArticleId articleId, ArticleTitle title, ArticleContent content, 
                                ArticleSlug slug, ArticleReadTime readTime, ArticleAuthorId authorId)
        {
            return new Article(articleId, title, slug, content, authorId, readTime);
        }


        public Article CreateArchived(ArticleId articleId, ArticleTitle title, ArticleContent content, 
                                ArticleSlug slug, ArticleReadTime readTime, ArticleAuthorId authorId)
        {
            var article = new Article(articleId, title, slug, content, authorId, readTime);

            article.Archive();

            return article;
        }


        public Article CreatePublished(ArticleId articleId, ArticleTitle title, ArticleContent content, 
                                ArticleSlug slug, ArticleReadTime readTime, ArticleAuthorId authorId)
        {
            var article = new Article(articleId, title, slug, content, authorId,  readTime);

            article.Publish();

            return article;
        }
    }
}
