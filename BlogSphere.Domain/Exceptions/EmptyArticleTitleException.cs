using BlogSphere.Shared.Abstractions.Exceptions;

namespace BlogSphere.Domain.Exceptions
{
    public class EmptyArticleTitleException: ArticleException
    {
        public EmptyArticleTitleException() : base("Article title cannot be empty.")
        {
        }
    }
}
