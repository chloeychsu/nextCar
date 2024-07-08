# nextCar

## Auction Service

```bash
dotnet new webapi -o src/AuctionService

# Nuget Packages
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package MassTransit
dotnet add package MassTransit.RabbitMQ
dotnet add package MassTransit.EntityFrameworkCore # For 資料一致性,建立 outbox 將失敗的資料存入 DB 等待時機再 Retry

# Entity Framware
dotnet tool list -g
dotnet tool install dotnet-ef -g 
dotnet tool update dotnet-ef -g 
# 建置
dotnet ef migrations add "InitialCreate" -o Data/Migrations
dotnet ef database update
# 刪除
dotnet ef database drop
```
## Search Service

```bash
dotnet new webapi -o src/SearchService

# Nuget Packages
dotnet add package MongoDB.Entities
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.Extensions.Http.Polly
<<<<<<< Updated upstream
=======
dotnet add package MassTransit
dotnet add package MassTransit.RabbitMQ
>>>>>>> Stashed changes



```
## Contract (Message Bus)

```bash
dotnet new classlib -o src/Contracts

```


## Github
```cs
dotnet new gitignore
```

## VSCode Extensions
[NuGet Gallery](https://marketplace.visualstudio.com/items?itemName=patcx.vscode-nuget-gallery)
[PostgreSQL](https://marketplace.visualstudio.com/items?itemName=ckolkman.vscode-postgres)
[MongoDB for VS Code](https://marketplace.visualstudio.com/items?itemName=mongodb.mongodb-vscode)