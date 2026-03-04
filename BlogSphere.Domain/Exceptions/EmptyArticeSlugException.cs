using BlogSphere.Domain.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Exceptions
{
    public class EmptyArticeSlugException: ArticleException
    {
        public EmptyArticeSlugException(): base("Article slug cannot be empty.")
        {
            
        }
    }
}
