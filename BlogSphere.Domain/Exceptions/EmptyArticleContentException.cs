using BlogSphere.Shared.Abstractions.Exceptions;

namespace BlogSphere.Domain.Exceptions
{
    public class EmptyArticleContentException: ArticleException
    {
        public EmptyArticleContentException() : base("Article content cannot be empty.")
        {

        }
    }
}
