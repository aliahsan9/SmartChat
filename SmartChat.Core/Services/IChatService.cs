
namespace SmartChat.Core.Services
{
    public interface IChatService
    {
        Task<string> AskAsync(string message);
    }
}
