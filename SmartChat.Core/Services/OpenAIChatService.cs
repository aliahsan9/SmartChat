
namespace SmartChat.Core.Services
{
    public class OpenAIChatService : IChatService
    {
        public async Task<string> AskAsync(string message)
        {
            return "AI response";
        }
    }
}
