using BlogSphere.Domain.Entities;
using BlogSphere.Domain.ValueObjects.Article;
using BlogSphere.Shared.Abstractions.Domain;

namespace BlogSphere.Domain.Events
{
    public record ArticleCommentAdded(Article articl, ArticleComment Comment) : IDomainEvent;
    
}
