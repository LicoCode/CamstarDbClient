using CamstarHelper.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace CamstarHelper.Context;

internal class CamstarDbContext : DbContext
{
    /// <summary>
    /// 数据库配置
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information)  //打印Info日志
            .UseLazyLoadingProxies()   //懒加载
            .UseSqlServer(@"Data Source=localhost;Initial Catalog=OLTP;User ID=opcenter;Password=Cam1star;Encrypt=True;TrustServerCertificate=True;");
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

    public DbSet<Product> Products { get; set; }
    public DbSet<ProductBase> ProductBases { get; set; }
    public DbSet<MfgOrder> MfgOrders { get; set; }
    public DbSet<UserOnlineQueryGroup> UserOnlineQueryGroups { get; set; }
    public DbSet<LossReasonGroup> LossReasonGroups { get; set; }
    public DbSet<Resource> Resources { get; set; }
    public DbSet<Feeder> Feeders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
        .HasOne(e => e.ProductBase)
        .WithMany(e => e.Revisions)
        .HasForeignKey("ProductBaseId")
        .IsRequired(true);

        modelBuilder.Entity<ProductBase>()
        .HasOne(e => e.RevOfRcd)
        .WithOne()
        .HasForeignKey<ProductBase>("RevOfRcdId")
        .IsRequired(true);

        modelBuilder.Entity<MfgOrder>()
        .HasOne(e => e.Product)
        .WithMany()
        .HasForeignKey("ProductId")
        .IsRequired(false);
        modelBuilder.Entity<MfgOrder>()
        .HasOne(e => e.ProductBase)
        .WithMany()
        .HasForeignKey("ProductBaseId")
        .IsRequired(false);

        modelBuilder.Entity<UserOnlineQueryGroup>()
        .HasMany(e => e.Entities) 
        .WithMany() 
        .UsingEntity<Dictionary<string, object>>(
            "NamedObjectGroupEntries",  
            l => l.HasOne<UserOnlineQuery>().WithMany().HasForeignKey("EntriesId"), 
            r => r.HasOne<UserOnlineQueryGroup>().WithMany().HasForeignKey("NamedObjectGroupId"), 
            j =>
            {
                j.HasKey("NamedObjectGroupId", "EntriesId");
                    
            }
        );

        modelBuilder.Entity<UserOnlineQueryGroup>()
        .HasMany(e => e.Groups)
        .WithMany()
        .UsingEntity<Dictionary<string, object>>(
            "NamedObjectGroupGroups",
            l => l.HasOne<UserOnlineQueryGroup>().WithMany().HasForeignKey("GroupsId"),
            r => r.HasOne<UserOnlineQueryGroup>().WithMany().HasForeignKey("NamedObjectGroupId"),
            j =>
            {
                j.HasKey("NamedObjectGroupId", "GroupsId");

            }
        );

        modelBuilder.Entity<LossReasonGroup>()
        .HasMany(e => e.Groups)
        .WithMany()
        .UsingEntity<Dictionary<string, object>>(
            "NamedObjectGroupGroups",
            l => l.HasOne<LossReasonGroup>().WithMany().HasForeignKey("GroupsId"),
            r => r.HasOne<LossReasonGroup>().WithMany().HasForeignKey("NamedObjectGroupId"),
            j =>
            {
                j.HasKey("NamedObjectGroupId", "GroupsId");

            }
        );

        modelBuilder.Entity<LossReasonGroup>()
        .HasMany(e => e.Entities)
        .WithMany()
        .UsingEntity<Dictionary<string, object>>(
            "NamedObjectGroupEntries",
            l => l.HasOne<LossReason>().WithMany().HasForeignKey("EntriesId"),
            r => r.HasOne<LossReasonGroup>().WithMany().HasForeignKey("NamedObjectGroupId"),
            j =>
            {
                j.HasKey("NamedObjectGroupId", "EntriesId");

            }
        );

        modelBuilder.Entity<Resource>()
        .HasDiscriminator(e => e.CDOTypeId)
        .HasValue<Feeder>(4792322)
        .HasValue<Resource>(1490);
    }
}
