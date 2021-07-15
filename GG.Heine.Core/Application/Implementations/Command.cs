using GG.Heine.Core.Application.Abstractions;

namespace GG.Heine.Core.Application.Implementations
{
    public abstract class Command : ICommand<CommandResult>
    {
        public bool IsValid { get; }

        public abstract void Validate();
    }
}
