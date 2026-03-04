using BlogSphere.Domain.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Exceptions
{
    internal class InvalidArticleIdException: ArticleException
    {
        public InvalidArticleIdException(string value): base($"Invalid article id: {value}")
        {
        }
    }
}
