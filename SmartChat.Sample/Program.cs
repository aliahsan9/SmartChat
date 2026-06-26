using SmartChat.Core.Extensions;
using SmartChat.Web.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new()
    {
        Title = "SmartChat API",
        Version = "v1",
        Description = "Lightweight AI Chat API built with SmartChat"
    });
});

builder.Services.AddSmartChat(options =>
{
    options.ApiKey = "test";
});

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.DocumentTitle = "SmartChat API";
        options.SwaggerEndpoint(
            "/swagger/v1/swagger.json",
            "SmartChat API v1");

        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

// System Endpoints

app.MapGet("/", () =>
{
    return Results.Ok(new
    {
        Name = "SmartChat",
        Version = "1.0.0",
        Status = "Running"
    });
})
.WithName("Root")
.WithTags("System");

app.MapGet("/health", () =>
{
    return Results.Ok(new
    {
        Status = "Healthy",
        Timestamp = DateTime.UtcNow
    });
})
.WithName("Health")
.WithTags("System");

// SmartChat Endpoints

app.MapSmartChat();

app.Run();