namespace SmartChat.Core.Providers;

public interface IChatProvider
{
    Task<string> AskAsync(
        string message,
        CancellationToken cancellationToken = default);
}