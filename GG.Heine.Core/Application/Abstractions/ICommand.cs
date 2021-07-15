using MediatR;

namespace GG.Heine.Core.Application.Abstractions
{
    public interface ICommand<TCommandResult> : IRequest<TCommandResult> where TCommandResult : ICommandResult
    {
        bool IsValid { get; }
        void Validate();
    }
}
