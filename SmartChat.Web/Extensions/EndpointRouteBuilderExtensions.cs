using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using SmartChat.Core.Models;
using SmartChat.Core.Services;

namespace SmartChat.Web.Extensions;

public static class EndpointRouteBuilderExtensions
{
    public static IEndpointRouteBuilder MapSmartChat(
        this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/chat", () =>
        {
            return Results.Ok(new
            {
                Message =
                    "Use POST /api/chat with a JSON body."
            });
        })
        .WithName("ChatInfo")
        .WithTags("Chat");

        app.MapPost("/api/chat",
            async (
                ChatRequest request,
                IChatService chatService) =>
            {
                var response =
                    await chatService.AskAsync(
                        request.Message);

                return Results.Ok(
                    new ChatResponse
                    {
                        Message = response
                    });
            })
            .WithName("Chat")
            .WithTags("Chat")
            .Produces<ChatResponse>(200)
            .ProducesProblem(400);

        return app;
    }
}