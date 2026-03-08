using BlogSphere.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Domain.ValueObjects.Article
{
    public record ArticleAuthorId
    {
        public Guid Value { get; }

        public ArticleAuthorId(Guid value) 
        {
            if(string.IsNullOrEmpty(value.ToString()))
            {
                throw new InvaldiArtilceAuthorIdException(value.ToString());
            }

            Value = value;
        }

        public static implicit operator Guid(ArticleAuthorId authorId) 
            => authorId.Value;

        public static implicit operator ArticleAuthorId(Guid value)
            => new ArticleAuthorId(value);

    }
}
