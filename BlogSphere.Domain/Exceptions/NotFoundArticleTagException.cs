using BlogSphere.Domain.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Exceptions
{
    public class NotFoundArticleTagException: ArticleException
    {
        public NotFoundArticleTagException(string name): base($"Article tag with name '{name}' not found.")
        {
        }
    }
}
