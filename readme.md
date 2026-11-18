# C# Learning Lab

A place to learn and practice C# and .NET, starting with a simple console app.

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [Visual Studio Code](https://code.visualstudio.com/) with the [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) extension for editing and debugging

The included dev container provides the SDK and VS Code extension when using GitHub Codespaces or VS Code Dev Containers.

## Build and run

From the repository root:

```sh
dotnet build ConsoleApp/ConsoleApp.csproj
dotnet run --project ConsoleApp/ConsoleApp.csproj
```

The app prints `Hello, World!`. Edit `ConsoleApp/Program.cs` to start practicing.

To debug in VS Code, open the repository folder and select **Debug ConsoleApp** in Run and Debug, then press F5.

This repository started from the [GitHub .NET Codespaces template](https://github.com/github/dotnet-codespaces).
