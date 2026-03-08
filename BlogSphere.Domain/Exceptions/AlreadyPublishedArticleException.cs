using BlogSphere.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Exceptions
{
    public class AlreadyPublishedArticleException: ArticleException
    {
        public AlreadyPublishedArticleException(string articleTitle):base($"Article '{articleTitle}' is already published.")
        {
            
        }
    }
}
