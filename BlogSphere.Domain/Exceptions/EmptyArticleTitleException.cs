using BlogSphere.Domain.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Exceptions
{
    public class EmptyArticleTitleException: ArticleException
    {
        public EmptyArticleTitleException() : base("Article title cannot be empty.")
        {
        }
    }
}
