StudentCRUD

A simple ASP.NET Core MVC web application that performs CRUD operations (Create, Read, Update, Delete) on a Student database using Entity Framework Core.

Tech Stack => 

ASP.NET Core MVC 9.0

Entity Framework Core (Code-First)

SQL Server (LocalDB)

Visual Studio 2022

How to Run => 

1) Clone the repository:

   git clone https://github.com/Himaja-98/StudentCRUD.git


2) Open the solution file StudentCRUD.sln in Visual Studio 2022.

3) Check the connection string in appsettings.json:

   "ConnectionStrings": {
       "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=StudentCRUD;Trusted_Connection=True;"
   }


4) Apply EF Core migrations:

5) dotnet ef database update


Run the project (Ctrl + F5) — it will open in your browser.

🧩 Entity Framework Commands
# Create a new migration
dotnet ef migrations add InitialCreate

# Apply migration and create database
dotnet ef database update

# Drop & recreate database (optional)
dotnet ef database drop
dotnet ef database update


 The database will be created automatically in your LocalDB instance.
You can view it in SQL Server Object Explorer inside Visual Studio.

📁 Folder Structure
Controllers/
Models/
Data/
Migrations/
Views/
appsettings.json
Program.cs

 Output -> 

Basic Student CRUD operations with:

Add new student

Edit student details

Delete record

View student list

<img width="1712" height="782" alt="image" src="https://github.com/user-attachments/assets/29ee2feb-099f-4654-af73-6c46a0504b67" />
<img width="1268" height="922" alt="image" src="https://github.com/user-attachments/assets/cabce9ff-d356-427a-ac32-f0c01cfe1ee5" />
<img width="922" height="872" alt="image" src="https://github.com/user-attachments/assets/4a763ac4-140c-4071-8c61-2553fc46bd11" />
<img width="832" height="866" alt="image" src="https://github.com/user-attachments/assets/e76468fc-17d9-4cc6-8ae8-e683369ed7ce" />
<img width="821" height="776" alt="image" src="https://github.com/user-attachments/assets/612ce617-3771-4ab9-b450-0e4b911d8c04" />

