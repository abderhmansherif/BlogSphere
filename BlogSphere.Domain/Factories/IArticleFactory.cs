using BlogSphere.Domain.Entities;
using BlogSphere.Domain.ValueObjects.Article;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Factories
{
    public interface IArticleFactory
    {
        Article CreateDraft(ArticleId articleId, ArticleTitle title, ArticleContent content, ArticleSlug slug,
                       ArticleReadTime readTime, ArticleAuthorId authorId);

        Article CreatePublished(ArticleId articleId, ArticleTitle title, ArticleContent content, ArticleSlug slug,
                        ArticleReadTime readTime, ArticleAuthorId authorId);
    }
}
