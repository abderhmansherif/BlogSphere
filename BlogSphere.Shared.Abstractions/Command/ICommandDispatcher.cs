using System;
using System.Collections.Generic;
using System.Text;

namespace BlogSphere.Shared.Abstractions.Command
{
    public interface ICommandDispatcher
    {
        Task DispatchAsync<TCommand>(TCommand command) where TCommand : ICommand;
    }
}
