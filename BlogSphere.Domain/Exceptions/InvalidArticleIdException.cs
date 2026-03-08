using BlogSphere.Shared.Abstractions.Exceptions;

namespace BlogSphere.Domain.Exceptions;

internal class InvalidArticleIdException: ArticleException
{
    public InvalidArticleIdException(string value): base($"Invalid article id: {value}")
    {
    }
}
