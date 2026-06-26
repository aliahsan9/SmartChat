using Microsoft.Extensions.DependencyInjection;
using SmartChat.Core.Providers;
using SmartChat.OpenAI.Providers;

namespace SmartChat.OpenAI.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddOpenAIProvider(
        this IServiceCollection services)
    {
        services.AddSingleton<IChatProvider,
            OpenAIChatProvider>();

        return services;
    }
}