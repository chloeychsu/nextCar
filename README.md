# nextCar

## Auction Service

```cs
dotnet new webapi -o src/AuctionService

// Nuget Packages
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL

// Entity Framware
dotnet tool list -g
dotnet tool install dotnet-ef -g 
dotnet tool update dotnet-ef -g 

dotnet ef migrations add "InitialCreate" -o Data/Migrations
```

## Github
```cs
dotnet new gitignore
```