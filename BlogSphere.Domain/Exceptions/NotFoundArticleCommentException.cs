using BlogSphere.Shared.Abstractions.Exceptions;

namespace BlogSphere.Domain.Exceptions
{
    public class NotFoundArticleCommentException: ArticleException
    {
        public NotFoundArticleCommentException(string content): base($"Article comment with content '{content}' not found.")
        {
            
        }
    }
}
