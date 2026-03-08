using BlogSphere.Shared.Abstractions.Command;


namespace BlogSphere.Application.Commands.CreateArticleCommand
{
    public record CreateArticleCommand(string Title, string Content, Guid AuthorId, int ReadTime) : ICommand;
    
}
