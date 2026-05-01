# Greed

Windows Forms charity operations app backed by SQL Server.

## Requirements

- Windows
- .NET 10 SDK
- SQL Server Express installed as the `SQLEXPRESS` named instance
- `sqlcmd` for database setup from the command line

## Install .NET SDK

```powershell
winget install -e --id Microsoft.DotNet.SDK.10
```

Verify:

```powershell
dotnet --version
```

## Install SQL Server Express

Run PowerShell as Administrator. This installs SQL Server Express using the normal Express named instance, `SQLEXPRESS`.

```powershell
winget install -e --id Microsoft.SQLServer.2025.Express
```

Verify the SQL Server Express instance exists and is running:

```powershell
Get-Service 'MSSQL$SQLEXPRESS'
Start-Service 'MSSQL$SQLEXPRESS'
sqlcmd -S ".\SQLEXPRESS" -E -C -Q "SELECT @@SERVERNAME, @@SERVICENAME;"
```

If `sqlcmd` is not available, install it:

```powershell
winget install -e --id Microsoft.Sqlcmd
```

## Create The Database

From the repository root:

```powershell
sqlcmd -S ".\SQLEXPRESS" -E -C -Q "IF DB_ID(N'project') IS NULL CREATE DATABASE [project];"
sqlcmd -S ".\SQLEXPRESS" -E -C -d project -i .\src\greed\Database\charity_db.sql
```

The app connection string should point to this named instance:

```text
Data Source=.\SQLEXPRESS;Initial Catalog=project;Integrated Security=True;
```

## Run The App

```powershell
dotnet run --project .\src\greed\greed.csproj
```

## Troubleshooting

If the app cannot connect to SQL Server, confirm the `SQLEXPRESS` instance is installed:

```powershell
Get-Service 'MSSQL$SQLEXPRESS'
sqlcmd -S ".\SQLEXPRESS" -E -C -Q "SELECT name FROM sys.databases;"
```

If `winget` creates `SQLEXPRESS01` or another numbered instance, remove the extra instance or update the connection string to match the installed instance name.
