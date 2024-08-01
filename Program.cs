using Microsoft.EntityFrameworkCore;
using WebAPIDemoLearning.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<SqlDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("PRSwilburDB")
        )
    );
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
