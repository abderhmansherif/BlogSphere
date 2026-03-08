using BlogSphere.Shared.Abstractions.Exceptions;

namespace BlogSphere.Domain.Exceptions
{
    public class EmptyArticeSlugException: ArticleException
    {
        public EmptyArticeSlugException(): base("Article slug cannot be empty.")
        {
            
        }
    }
}
