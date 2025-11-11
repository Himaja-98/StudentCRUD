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


Output
<img width="1712" height="782" alt="image" src="https://github.com/user-attachments/assets/29ee2feb-099f-4654-af73-6c46a0504b67" />
<img width="1268" height="922" alt="image" src="https://github.com/user-attachments/assets/cabce9ff-d356-427a-ac32-f0c01cfe1ee5" />
