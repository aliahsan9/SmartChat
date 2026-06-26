using Microsoft.Extensions.DependencyInjection;
using SmartChat.Core.Options;
using SmartChat.Core.Providers;
using SmartChat.Core.Services;

namespace SmartChat.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSmartChat(
        this IServiceCollection services,
        Action<SmartChatOptions> configure)
    {
        services.Configure(configure);

        services.AddScoped<IChatService,
            FakeChatService>();
        services.AddSingleton<IChatProvider,
    FakeChatProvider>();

        services.AddScoped<IChatService,
            ChatService>();

        return services;
    }
}