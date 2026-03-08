using BlogSphere.Domain.Entities;
using BlogSphere.Domain.ValueObjects.Article;
using BlogSphere.Shared.Abstractions.Domain;

namespace BlogSphere.Domain.Events
{
    public record ArticleTagRemoved(Article Article, ArticleTag tag) : IDomainEvent;

}
