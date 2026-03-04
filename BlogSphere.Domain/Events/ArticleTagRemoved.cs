using BlogSphere.Domain.Abstractions.Domain;
using BlogSphere.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Events
{
    public record ArticleTagRemoved(Article Article, Tag tag) : IDomainEvent;

}
