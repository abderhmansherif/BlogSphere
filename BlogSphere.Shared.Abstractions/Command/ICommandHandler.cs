using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Shared.Abstractions.Command
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        Task HandleAsync(TCommand command);
    }
}
