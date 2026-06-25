# SmartChat

SmartChat is a lightweight ASP.NET Core library that enables developers to add AI-powered chat capabilities to their applications with minimal setup.

The library is designed to provide a simple integration experience while remaining flexible enough to support custom user interfaces, business workflows, and AI providers.

## Why SmartChat

Adding conversational AI to an application often requires significant boilerplate code, API integration, endpoint configuration, and infrastructure setup. SmartChat aims to reduce that complexity by providing a clean, reusable integration layer for ASP.NET Core applications.

## Features

* Simple ASP.NET Core integration
* Minimal configuration
* OpenAI support
* Extensible architecture
* Endpoint-based implementation
* Suitable for web applications, internal tools, and SaaS platforms

## Installation

```bash
dotnet add package SmartChat
```

## Getting Started

Register SmartChat during application startup:

```csharp
builder.Services.AddSmartChat(options =>
{
    options.ApiKey = "your-api-key";
});
```

Map the SmartChat endpoints:

```csharp
app.MapSmartChat();
```

The chat endpoint is now available and ready to receive requests.

## Example Request

```http
POST /smartchat/chat
Content-Type: application/json

{
    "message": "Hello"
}
```

## Roadmap

The following features are planned for future releases:

* Streaming responses
* Multiple AI provider support
* Conversation persistence
* Authentication and authorization integration
* Custom UI components
* Plugin architecture

## Contributing

Contributions, bug reports, and feature requests are welcome. Please open an issue before starting significant changes so that the proposed solution can be discussed.

## License

This project is licensed under the MIT License.
