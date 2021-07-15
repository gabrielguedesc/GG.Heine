namespace GG.Heine.Abstractions.Application
{
    public interface ICommandResult
    {
        bool Success { get; }
        object Data { get; set; }
        string Message { get; set; }
    }
}
