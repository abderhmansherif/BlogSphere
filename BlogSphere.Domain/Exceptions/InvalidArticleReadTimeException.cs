using BlogSphere.Domain.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Exceptions
{
    public class InvalidArticleReadTimeException: ArticleException
    {
        public InvalidArticleReadTimeException(string value): base($"Invalid article read time: {value}, must be in minutes")
        {
        }
    }
}
