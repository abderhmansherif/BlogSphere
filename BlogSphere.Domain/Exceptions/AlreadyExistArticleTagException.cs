using BlogSphere.Domain.Abstractions.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.Exceptions
{
    public class AlreadyExistArticleTagException: ArticleException
    {
        public AlreadyExistArticleTagException(string name): base($"Article tag with name '{name}' already exists.")
        {
            
        }
    }
}
