# StudentCRUD
ASP.NET Core MVC + Entity Framework Core sample app (Student CRUD).

## Tech
- .NET 9 / ASP.NET Core
- EF Core (Code-First)
- SQL Server (local / connection string in appsettings)
- Tools: Visual Studio 2022, Postman

## How to run (local)
1. Clone: `git clone https://github.com/Himaja-98/StudentCRUD.git`
2. Open solution `AspNetCoreCRUD.sln` in Visual Studio 2022.
3. Update connection string in `appsettings.Development.json` (do NOT commit secrets).
4. Apply migrations:
   ```bash
   dotnet ef database update --project AspNetCoreCRUD
