# Klaviyo C# Client

This repository contains a generated C# client for the Klaviyo API. The client is automatically generated using the [Kiota](https://github.com/microsoft/kiota) tool based on the Klaviyo OpenAPI specification.

## Overview

This client provides a convenient way to interact with the Klaviyo API using C#. It includes all the endpoints and models defined in the Klaviyo OpenAPI specification.

This is a .NET Standard library, which means it can be used in a wide range of .NET projects, including .NET Framework, .NET Core, and .NET 5+.

## Usage

To use this client in your C# project, simply include the generated files in your project and initialize the client with your Klaviyo API credentials.

```csharp
using ApiSdk;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

// Initialize the API client
var authProvider = new ApiKeyAuthenticationProvider("your-api-key-here");
var httpClient = new HttpClientRequestAdapter(authProvider);
var client = new ApiClient(httpClient);

// Get campaigns
try
{
  var campaigns = await client.Api.Campaigns.GetAsync();
  foreach (var campaign in campaigns.Data)
  {
    Console.WriteLine($"Campaign ID: {campaign.Id}, Name: {campaign.Attributes.Name}");
  }
}
catch (Exception ex)
{
  Console.WriteLine($"Error: {ex.Message}");
}
```

## Generation

This client is automatically generated using Kiota. To update the client, re-run the Kiota generator with the latest Klaviyo OpenAPI specification.

```bash
./gen.sh
```

## Building

```bash
cd KlaviyoApi
dotnet build -c Release .
```

## Documentation

For detailed information on how to use the Klaviyo API, please refer to the [official Klaviyo API documentation](https://developers.klaviyo.com/en/reference).