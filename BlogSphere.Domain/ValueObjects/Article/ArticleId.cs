using BlogSphere.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.ValueObjects.Article
{
    public record ArticleId
    {
        public Guid Value { get; }
        public ArticleId(Guid value)
        {
            if (string.IsNullOrEmpty(value.ToString()))
            {
                throw new InvalidArticleIdException(value.ToString());
            }

            Value = value;
        }


        public static implicit operator Guid(ArticleId articleId) 
            => articleId.Value;
        public static implicit operator ArticleId(Guid value)
            => new ArticleId(value);
    }
}
