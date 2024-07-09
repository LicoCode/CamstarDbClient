using CamstarDb.Config;
using CamstarDb.Entities;
using Microsoft.EntityFrameworkCore;

namespace CamstarDb.Context;

public partial class CamstarDbContext : DbContext
{
    /// <summary>
    /// 数据库配置
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var options = optionsBuilder.UseLazyLoadingProxies();
        if (DbConfiguration.LoggerFactory != null) {
            optionsBuilder.UseLoggerFactory(DbConfiguration.LoggerFactory);
        }
        if (DbConfiguration.DbType.ToUpper() == "ORACLE")
        {
            options.UseOracle(DbConfiguration.ConnectionString);
        }
        else if (DbConfiguration.DbType.ToUpper() == "MSSQL")
        {
            options.UseSqlServer(DbConfiguration.ConnectionString);
        }
    }

    public override int SaveChanges()
    {
        var entries = ChangeTracker.Entries()
            .Where(e => e.State == EntityState.Added ||
                        e.State == EntityState.Modified ||
                        e.State == EntityState.Deleted);
        if (entries.Any())
        {
            throw new InvalidOperationException("Updates are not allowed");
        }
        return base.SaveChanges();
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyAllConfigurations(typeof(CamstarDbContext).Assembly);
    }
}
