using BlogSphere.Domain.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Exceptions
{
    public class AlreadyArchivedArticleException: ArticleException
    {
        public AlreadyArchivedArticleException(string articleTitle): base($"Article '{articleTitle}' is already archived.")
        {
            
        }
    }
}
