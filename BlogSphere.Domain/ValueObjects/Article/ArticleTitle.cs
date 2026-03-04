using BlogSphere.Domain.Abstractions;
using BlogSphere.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.ValueObjects.Article
{
    public record ArticleTitle
    {
        public string Value { get;}

        public ArticleTitle(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new EmptyArticleTitleException();
            }

            Value = value;
        }

        public static implicit operator string(ArticleTitle title) 
            => title.Value;

        public static implicit operator ArticleTitle(string value)
            => new ArticleTitle(value);
    }
}
