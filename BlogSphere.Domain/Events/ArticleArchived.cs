using BlogSphere.Domain.Entities;
using BlogSphere.Shared.Abstractions.Domain;

namespace BlogSphere.Domain.Events
{
    public record ArticleArchived(Article Article) : IDomainEvent;
    
}
