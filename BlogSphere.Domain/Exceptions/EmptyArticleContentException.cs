using BlogSphere.Domain.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Exceptions
{
    public class EmptyArticleContentException: ArticleException
    {
        public EmptyArticleContentException() : base("Article content cannot be empty.")
        {

        }
    }
}
