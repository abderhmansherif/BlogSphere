using BlogSphere.Shared.Abstractions.Exceptions;

namespace BlogSphere.Domain.Exceptions
{
    public class InvalidArticleReadTimeException: ArticleException
    {
        public InvalidArticleReadTimeException(string value): base($"Invalid article read time: {value}, must be in minutes")
        {
        }
    }
}
