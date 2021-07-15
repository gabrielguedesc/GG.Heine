using GG.Heine.Core.Application.Abstractions;
using System.Threading;
using System.Threading.Tasks;

namespace GG.Heine.Core.Application.Implementations
{
    public abstract class Handler<TCommand> : IHandler<TCommand> where TCommand : ICommand<CommandResult>
    {
        public async Task<CommandResult> Handle(TCommand request, CancellationToken cancellationToken)
        {
            return await HandleCommandAsync(request, cancellationToken);
        }

        public abstract Task<CommandResult> HandleCommandAsync(TCommand command, CancellationToken cancellationToken);
    }
}
