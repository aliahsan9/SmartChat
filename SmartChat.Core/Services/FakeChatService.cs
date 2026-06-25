namespace SmartChat.Core.Services;

public sealed class FakeChatService : IChatService
{
    public Task<string> AskAsync(string message)
    {
        return Task.FromResult(
            $"You said: {message}");
    }
}