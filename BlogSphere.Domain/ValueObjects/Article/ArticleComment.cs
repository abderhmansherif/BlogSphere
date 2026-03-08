using BlogSphere.Domain.Exceptions;

namespace BlogSphere.Domain.ValueObjects.Article
{
    public record ArticleComment 
    {
        public string Content { get;}
        public Guid AuthorId { get;}
        public DateTime CreatedAt { get;}

        public ArticleComment(string content, Guid authorId)
        {
            if(string.IsNullOrEmpty(content) || string.IsNullOrEmpty(authorId.ToString()))
            {
                throw new InvalidArticleCommentDataException();
            }
            this.Content = content;
            this.AuthorId = authorId;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
