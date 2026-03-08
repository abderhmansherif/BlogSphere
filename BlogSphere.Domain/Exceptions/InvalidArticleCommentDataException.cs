using BlogSphere.Shared.Abstractions.Exceptions;

namespace BlogSphere.Domain.Exceptions
{
    public class InvalidArticleCommentDataException: ArticleException
    {
        public InvalidArticleCommentDataException():base("Article Comment Data are not valid.")
        {
            
        }
    }
}
