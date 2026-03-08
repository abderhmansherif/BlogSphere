using BlogSphere.Shared.Abstractions.Exceptions;

namespace BlogSphere.Domain.Exceptions
{
    public class InvaldiArtilceAuthorIdException: ArticleException
    {
        public InvaldiArtilceAuthorIdException(string value): base($"Invalid article author id: {value}")
        { 
        }
    }
}
