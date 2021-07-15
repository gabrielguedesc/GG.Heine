using GG.Heine.Core.Application.Abstractions;

namespace GG.Heine.Core.Application.Implementations
{
    public class CommandResult : ICommandResult
    {
        public bool Success { get; set; }
        public object Data { get; set; }
        public string Message { get; set; }

        public CommandResult(bool success, object data, string message)
        {
            Success = success;
            Data = data;
            Message = message;
        }
    }
}
