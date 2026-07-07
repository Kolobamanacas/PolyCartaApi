using Microsoft.EntityFrameworkCore;
using PolyCartaApi.Modules.Shared.Configurations.Database;
using PolyCartaApi.Modules.Shared.Configurations.Routing;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("secrets.json", optional: true, reloadOnChange: false);

builder.Services.AddDbContext<AppDbContext>((options) =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL")));

var app = builder.Build();

app.UseHttpsRedirection();
app.MapHttpControllers();

app.Run();
