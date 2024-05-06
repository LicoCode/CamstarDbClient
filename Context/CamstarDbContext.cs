using CamstarDbClient.Config;
using CamstarDbClient.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace CamstarDbClient.Context;

public partial class CamstarDbContext : DbContext
{
    /// <summary>
    /// 数据库配置
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var options = optionsBuilder.LogTo(Console.WriteLine, LogLevel.Debug)  //打印Info日志
            .UseLazyLoadingProxies();   //懒加载
        if (DbConfiguration.Type.ToUpper() == "ORACLE")
        {
            options.UseOracle(DbConfiguration.DefaultConnection);
        }
        else if(DbConfiguration.Type.ToUpper() == "SQLSERVER")
        {
            options.UseSqlServer(DbConfiguration.DefaultConnection);
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
