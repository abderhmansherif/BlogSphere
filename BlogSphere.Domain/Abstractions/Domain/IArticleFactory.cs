using BlogSphere.Domain.Enums;
using BlogSphere.Domain.Models;
using BlogSphere.Domain.ValueObjects.Article;


namespace BlogSphere.Domain.Abstractions.Domain
{
    public interface IArticleFactory
    {
        Article CreateDDraft(ArticleId articleId, ArticleTitle title, ArticleContent content, ArticleSlug slug,
                        ArticleReadTime readTime, ArticleAuthorId authorId);

        Article CreatePublished(ArticleId articleId, ArticleTitle title, ArticleContent content, ArticleSlug slug,
                        ArticleReadTime readTime, ArticleAuthorId authorId);

        Article CreateArchived(ArticleId articleId, ArticleTitle title, ArticleContent content, ArticleSlug slug,
                        ArticleReadTime readTime, ArticleAuthorId authorId);
    }
}
