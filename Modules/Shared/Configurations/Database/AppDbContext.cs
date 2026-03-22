using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace PolyCartaApi.Modules.Shared.Configurations.Database;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var entityTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.GetCustomAttribute<DataBaseTableAttribute>() != null);

        foreach (var type in entityTypes)
        {
            string? tableName = type.GetCustomAttribute<DataBaseTableAttribute>()?.TableName;

            if (tableName == null)
            {
                throw new Exception($"Table name is not specified for the type {type.FullName}.");
            }

            modelBuilder.Entity(type).ToTable(tableName);
        }
    }
}
