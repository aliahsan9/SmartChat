namespace SmartChat.Core.Providers;

public sealed class FakeChatProvider
    : IChatProvider
{
    public Task<string> AskAsync(
        string message,
        CancellationToken cancellationToken = default)
    {
        return Task.FromResult(
            $"Echo: {message}");
    }
}