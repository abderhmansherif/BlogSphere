using BlogSphere.Domain.Abstractions.Domain;
using BlogSphere.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Events
{
    public record ArticleCommentAdded(Article articl, Comment Comment) : IDomainEvent;
    
}
