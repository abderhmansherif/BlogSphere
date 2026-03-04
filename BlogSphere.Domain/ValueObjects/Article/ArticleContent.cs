using BlogSphere.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.ValueObjects.Article
{
    public record ArticleContent
    {
        public string Value { get; }

        public ArticleContent(string value)
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new EmptyArticleContentException();
            }

            Value = value;
        }

        public static implicit operator string(ArticleContent content) 
            => content.Value;

        public static implicit operator ArticleContent(string value)
            => new ArticleContent(value);
    }
}
