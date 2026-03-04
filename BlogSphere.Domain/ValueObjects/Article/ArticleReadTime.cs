using BlogSphere.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.ValueObjects.Article
{
    public record ArticleReadTime
    {
        public int Value { get; }

        public ArticleReadTime(int value)
        {
            if(value <= 0)
            {
                throw new InvalidArticleReadTimeException(value.ToString());
            }

            Value = value;
        }

        public static implicit operator int(ArticleReadTime readTime) 
            => readTime.Value;

        public static implicit operator ArticleReadTime(int value)
            => new ArticleReadTime(value);
    }
}
