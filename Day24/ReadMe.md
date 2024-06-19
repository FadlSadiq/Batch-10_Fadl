dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet tool list --global
dotnet tool instal dotnet-ef --global
dotnet-ef migrations add "Initial Database"
dotnet-ef database update