using BlogSphere.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Exceptions
{
    public class CannotArchiveArticleException: ArticleException
    {
        public CannotArchiveArticleException(): base("Only Published articles can be archived")
        {
            
        }
    }
}
