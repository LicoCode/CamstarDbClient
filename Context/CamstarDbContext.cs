using CamstarClient.Entity;
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
            .UseOracle(@"DATA SOURCE=LOCALHOST:1521/orclpdb;USER ID=OPCENTERDBUSER;PASSWORD=Oracle.123;");
            //.UseSqlServer(@"Data Source=localhost;Initial Catalog=insitedb;User ID=sa;Password=abcABC@123;Encrypt=True;TrustServerCertificate=True;");
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
    public DbSet<LossReasonGroup> LossReasonGroups { get; set; }
    public DbSet<Resource> Resources { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Product
        modelBuilder.Entity<Product>()
        .HasOne(e => e.Base)
        .WithMany(e => e.Revisions)
        .HasForeignKey("PRODUCTBASEID")
        .IsRequired(true);
        modelBuilder.Entity<Product>()
       .HasOne(e => e.Workflow)
       .WithMany()
       .HasForeignKey("WORKFLOWID")
       .IsRequired(true);


        modelBuilder.Entity<ProductBase>()
        .HasOne(e => e.RevOfRcd)
        .WithOne()
        .HasForeignKey<ProductBase>("REVOFRCDID")
        .IsRequired(true);

        //Workflow
        modelBuilder.Entity<Workflow>()
        .HasOne(e => e.Base)
        .WithMany()
        .HasForeignKey("WORKFLOWID")
        .IsRequired(true);

        modelBuilder.Entity<WorkflowBase>()
        .HasOne(e => e.RevOfRcd)
        .WithOne()
        .HasForeignKey<WorkflowBase>("RevOfRcdId")
        .IsRequired(true);

        modelBuilder.Entity<MfgOrder>()
        .HasOne(e => e.Product)
        .WithMany()
        .HasForeignKey("PRODUCTID")
        .IsRequired(false);
        modelBuilder.Entity<MfgOrder>()
        .HasOne(e => e.ProductBase)
        .WithMany()
        .HasForeignKey("PRODUCTBASEID")
        .IsRequired(false);

        /*modelBuilder.Entity<UserOnlineQueryGroup>()
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
        );*/

        /*modelBuilder.Entity<UserOnlineQueryGroup>()
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
        );*/

        modelBuilder.Entity<LossReasonGroup>()
        .HasMany(e => e.Groups)
        .WithMany()
        .UsingEntity<Dictionary<string, object>>(
            "NAMEDOBJECTGROUPGROUPS",
            l => l.HasOne<LossReasonGroup>().WithMany().HasForeignKey("GROUPSID"),
            r => r.HasOne<LossReasonGroup>().WithMany().HasForeignKey("NAMEDOBJECTGROUPID"),
            j =>
            {
                j.HasKey("NAMEDOBJECTGROUPID", "GROUPSID");

            }
        );

        modelBuilder.Entity<LossReasonGroup>()
        .HasMany(e => e.Entries)
        .WithMany()
        .UsingEntity<Dictionary<string, object>>(
            "NAMEDOBJECTGROUPENTRIES",
            l => l.HasOne<LossReason>().WithMany().HasForeignKey("ENTRIESID"),
            r => r.HasOne<LossReasonGroup>().WithMany().HasForeignKey("NAMEDOBJECTGROUPID"),
            j =>
            {
                j.HasKey("NAMEDOBJECTGROUPID", "ENTRIESID");

            }
        );

        modelBuilder.Entity<Resource>()
        .HasDiscriminator(e => e.CDOTypeId);
        /*.HasValue<Feeder>(4792322)
        .HasValue<Resource>(1490);*/
    }
}
