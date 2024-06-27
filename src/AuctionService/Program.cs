using AuctionService.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<AuctionDbContext>(opt =>{
    opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// 從 assembilies 找到所有繼承 Profile 的物件並提供服務
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

try
{
    DbInitializer.InitDb(app);
}
catch (System.Exception e)
{
    Console.WriteLine(e);
}

app.Run();
