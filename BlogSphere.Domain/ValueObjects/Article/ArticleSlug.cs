using BlogSphere.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.ValueObjects.Article
{
    public record ArticleSlug
    {
        public string Value { get; }

        public ArticleSlug(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new EmptyArticeSlugException();
            }
            Value = value;
        }

        public static implicit operator string(ArticleSlug slug) 
            => slug.Value;

        public static implicit operator ArticleSlug(string value)
            => new ArticleSlug(value);
    }
}
