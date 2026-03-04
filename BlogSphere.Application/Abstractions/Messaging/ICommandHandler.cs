

namespace BlogSphere.Application.Abstractions.Messaging
{
    public interface ICommandHandler<TCommand, TResult>
    {
        Task<TResult> HandleAsync(TCommand command);
    }
}
