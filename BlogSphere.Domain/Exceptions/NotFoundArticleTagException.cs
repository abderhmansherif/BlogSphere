using BlogSphere.Shared.Abstractions.Exceptions;

namespace BlogSphere.Domain.Exceptions
{
    public class NotFoundArticleTagException: ArticleException
    {
        public NotFoundArticleTagException(string name): base($"Article tag with name '{name}' not found.")
        {
        }
    }
}
