# Agent Guidelines

## Repository purpose

This repository is a small C# and .NET learning lab for preparing for a C# test from a Java background. Prefer changes that reinforce language fundamentals and produce clear, runnable practice examples over unnecessary application complexity.

## Repository layout

- `ConsoleApp/` contains the .NET console project.
- `ConsoleApp/Program.cs` is the current practice entry point.
- `ConsoleApp/ConsoleApp.csproj` targets .NET 8 with nullable reference types and implicit usings enabled.
- `.github/workflows/build.yml` builds the project for pull requests targeting `main`.
- `.devcontainer/` and `.vscode/` provide the supported development environment and build/debug tasks.
- `bin/` and `obj/` are generated build artifacts. Do not edit or commit them.

## Development commands

Run commands from the repository root:

```sh
dotnet build ConsoleApp/ConsoleApp.csproj
dotnet run --project ConsoleApp/ConsoleApp.csproj
```

Use a Release build when checking the same build mode used by CI:

```sh
dotnet build ConsoleApp/ConsoleApp.csproj --configuration Release
```

There is currently no automated test project. When adding behavior that warrants repeatable verification, prefer adding focused tests in a separate test project rather than relying only on manual console output.

## Coding and learning practices

- Keep examples small, readable, and directly related to the current learning objective.
- Prefer explicit, descriptive names and normal C# casing conventions: PascalCase for types and members, camelCase for local variables and parameters.
- Preserve nullable-reference safety. Handle nullable input such as `Console.ReadLine()` deliberately instead of suppressing warnings without a reason.
- Convert and validate console input explicitly with suitable APIs such as `int.TryParse`; do not assume input strings become numbers automatically.
- Use interpolation for composed output when it improves readability.
- Avoid introducing abstractions, packages, or framework features that obscure the concept being practiced.
- Keep comments focused on the C# or .NET concept being demonstrated, not on obvious syntax.

## Java-to-C# transition

When an example overlaps with Java, make the C# difference clear in the code or nearby explanation. In particular:

- C# uses properties, records, delegates, events, and extension methods as common language features; do not assume every Java pattern maps directly.
- `string` is an alias for `System.String`, and value types such as `int` differ from reference types in important ways.
- Nullable reference types are compiler analysis and annotations, not the same thing as making a value nullable at runtime.
- Use C# idioms such as expression-bodied members, pattern matching, `var` when the type is obvious, and `using` declarations when they improve clarity; do not use them merely to make examples shorter.
- Remember that .NET projects, SDK-style `.csproj` files, NuGet packages, and the `dotnet` CLI provide the build and dependency model.

## Change and validation workflow

- Read the relevant existing files before changing them and keep changes scoped to the learning goal.
- Do not modify generated files under `bin/` or `obj/`.
- Preserve the existing .NET 8 target unless the task explicitly changes the supported runtime.
- Before considering a code change complete, run the smallest relevant build or test command and inspect compiler warnings and errors.
- Keep documentation and agent guidance consistent with `readme.md`, the project file, and CI workflow.
