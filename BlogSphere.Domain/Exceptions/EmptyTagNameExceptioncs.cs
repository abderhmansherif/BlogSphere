using BlogSphere.Shared.Abstractions.Exceptions;

namespace BlogSphere.Domain.Exceptions
{
    public class EmptyTagNameExceptioncs: ArticleException
    {
        public EmptyTagNameExceptioncs(): base("The Tag Name Cannot be empty.")
        {
        }
    }
}
