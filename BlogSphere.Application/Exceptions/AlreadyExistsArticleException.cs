using BlogSphere.Shared.Abstractions.Exceptions;

namespace BlogSphere.Application.Exceptions
{
    public class AlreadyExistsArticleException: ArticleException
    {
        public AlreadyExistsArticleException(string title): base($"The Article with that '{title}' Title already exists")
        {
            
        }
    }
}
