using BlogSphere.Domain.ValueObjects.Article;
using System;
using System.Collections.Generic;
using System.Text;

using BlogSphere.Domain.Exceptions;

namespace BlogSphere.Domain.ValueObjects.Article
{
    public class ArticleTag 
    {
        public string Name { get; }

        public ArticleTag(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new EmptyTagNameExceptioncs();
            }

            Name = name;
        }

        public static implicit operator ArticleTag(string name)
            => new ArticleTag(name);

        public static implicit operator string(ArticleTag tag)
            => tag.Name;    
    }
}
