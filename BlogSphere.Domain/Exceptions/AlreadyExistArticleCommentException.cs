using BlogSphere.Domain.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Exceptions
{
    public class AlreadyExistArticleCommentException: ArticleException
    {
        public AlreadyExistArticleCommentException(string commentTitle): base($"Comment with title '{commentTitle}' already exists.")
        {
            
        }
    }
}
