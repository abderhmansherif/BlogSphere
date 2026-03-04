using BlogSphere.Domain.Abstractions.Domain;
using BlogSphere.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Events
{
    public record ArticleCommentRemoved(Article Article, Comment Comment) : IDomainEvent;
}
