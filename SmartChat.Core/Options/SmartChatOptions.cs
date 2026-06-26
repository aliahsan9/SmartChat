namespace SmartChat.Core.Options;

public sealed class SmartChatOptions
{
    public string ApiKey { get; set; } = string.Empty;

    public string Model { get; set; } = "gpt-4.1-mini";
}