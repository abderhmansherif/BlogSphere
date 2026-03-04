
namespace BlogSphere.Application.Commandss
{
    public record CreateArticleCommand(string Title, string Content, 
                                        string CoverImage, int ReadTime, int AuthorId,
                                        List<string> Tags);
    
}
