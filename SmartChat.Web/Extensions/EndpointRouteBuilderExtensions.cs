using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace SmartChat.Web.Extensions;

public static class EndpointRouteBuilderExtensions
{
    public static IEndpointRouteBuilder MapSmartChat(
        this IEndpointRouteBuilder app)
    {
        app.MapGet("/smartchat", () => "SmartChat is running");

        return app;
    }
}