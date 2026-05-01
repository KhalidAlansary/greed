# Contributing

## Development Setup

Install Visual Studio Community with the .NET desktop development workload:

```powershell
winget install -e --id Microsoft.VisualStudio.Community --override "--wait --quiet --add Microsoft.VisualStudio.Workload.ManagedDesktop --includeRecommended"
```

If Visual Studio is already installed, open the Visual Studio Installer and add the `.NET desktop development` workload, or run the installer modify command from the Visual Studio Installer location.

Install the .NET SDK used by the project:

```powershell
winget install -e --id Microsoft.DotNet.SDK.10
```

Install SQL Server Express and initialize the database by following `README.md`.

## Build

```powershell
dotnet restore .\greed.slnx
dotnet build .\greed.slnx
```

## Run

```powershell
dotnet run --project .\src\greed\greed.csproj
```

## Database

The app expects a SQL Server database named `project` on the `SQLEXPRESS` named instance:

```text
Data Source=.\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;
```

Create and seed the database with:

```powershell
sqlcmd -S ".\SQLEXPRESS" -E -C -Q "IF DB_ID(N'project') IS NULL CREATE DATABASE [project];"
sqlcmd -S ".\SQLEXPRESS" -E -C -d project -i .\src\greed\Database\charity_db.sql
```

## Before Submitting Changes

Run:

```powershell
dotnet build .\greed.slnx --no-incremental
git diff --check
```

Avoid committing generated or local files such as `.vs/`, `bin/`, `obj/`, and `*.user`.
