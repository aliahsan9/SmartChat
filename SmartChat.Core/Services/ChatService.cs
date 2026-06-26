using SmartChat.Core.Providers;

namespace SmartChat.Core.Services;

public sealed class ChatService
    : IChatService
{
    private readonly IChatProvider _provider;

    public ChatService(
        IChatProvider provider)
    {
        _provider = provider;
    }

    public Task<string> AskAsync(
        string message)
    {
        return _provider.AskAsync(message);
    }
}