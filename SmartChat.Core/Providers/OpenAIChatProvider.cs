using SmartChat.Core.Providers;

namespace SmartChat.OpenAI.Providers;

public sealed class OpenAIChatProvider
    : IChatProvider
{
    public async Task<string> AskAsync(
        string message,
        CancellationToken cancellationToken = default)
    {
        return "Not Implemented";
    }
}