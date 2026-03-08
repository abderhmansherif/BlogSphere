using BlogSphere.Domain.Enums;
using BlogSphere.Domain.Entities;
using BlogSphere.Domain.ValueObjects.Article;

namespace BlogSphere.Domain.Factories
{
    public class ArticleFactory : IArticleFactory
    {
   
        public Article CreateDraft(ArticleId articleId, ArticleTitle title, ArticleContent content, 
                                ArticleSlug slug, ArticleReadTime readTime, ArticleAuthorId authorId)
        {
            return new Article(articleId, title, slug, content, authorId, readTime);
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
