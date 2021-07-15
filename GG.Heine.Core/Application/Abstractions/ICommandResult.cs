namespace GG.Heine.Core.Application.Abstractions
{
    public interface ICommandResult
    {
        bool Success { get; }
        object Data { get; set; }
        string Message { get; set; }
    }
}
