using Microsoft.Extensions.DependencyInjection;
using SmartChat.Core.Options;

namespace SmartChat.Core.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSmartChat(
        this IServiceCollection services,
        Action<SmartChatOptions> configure)
    {
        var options = new SmartChatOptions();

        configure(options);

        services.AddSingleton(options);

        return services;
    }
}