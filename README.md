# Welcome to DumGame

A work-in-progress web game built with ASP.NET Core Blazor, C#, and Tailwind CSS.

*This was supposed to be a sample project to get to know the Blazor framework lmao.*

## Getting Started

To run the project on your system, first clone the repository:

```bash
git clone https://github.com/venzblanz/DumGame.git
```

Then navigate into the project directory:

```bash
cd DumGame
```

## Restore the .NET packages

```bash
dotnet restore
```

## Install the npm dependencies

```bash
npm install
```

## BUT BEFORE ANYTHING ELSE! Check your .NET version

DumGame currently targets **.NET 8**

Check your installed .NET SDK version:

```bash
dotnet --version
```

Make sure you have the **.NET 8 SDK** installed before running the project.

If you have a different version installed, such as .NET 10, install the .NET 8 SDK as well rather than changing the project's target framework.

You can install .NET 8 by visiting [Microsoft Official Page](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

Or you can just run this directly in the same command prompt:

```bash
winget install --id Microsoft.DotNet.SDK.8
```

You can then verify the version again:

```bash
dotnet --version
```

## Run the application

You can run the application using:

```bash
dotnet run
```

Or, if you want the application to automatically reload when you make changes:

```bash
dotnet watch
```
