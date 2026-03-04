using BlogSphere.Domain.Abstractions.Domain;
using BlogSphere.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Exceptions
{
    public class NotFoundArticleCommentException: ArticleException
    {
        public NotFoundArticleCommentException(string content): base($"Article comment with content '{content}' not found.")
        {
            
        }
    }
}
