using GG.Heine.Core.Application.Implementations;
using MediatR;

namespace GG.Heine.Core.Application.Abstractions
{
    public interface IHandler<TCommand> : IRequestHandler<TCommand, CommandResult> where TCommand : ICommand<CommandResult>
    {
    }
}
