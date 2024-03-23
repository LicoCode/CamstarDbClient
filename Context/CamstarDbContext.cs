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
    public DbSet<Resource> Resources { get; set; }
    public DbSet<Container> Containers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        /*
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
        .;

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
        .HasValue<Feeder>(4792322)
        .HasValue<Resource>(1490);*/

        //Container
        modelBuilder.Entity<Container>().HasOne(m => m.Level).WithMany().HasForeignKey("LEVELID").IsRequired(false);
        modelBuilder.Entity<Container>().HasOne(m => m.SplitFrom).WithMany().HasForeignKey("SPLITFROMID").IsRequired(false);
        modelBuilder.Entity<Container>().HasOne(m => m.Parent).WithMany().HasForeignKey("PARENTCONTAINERID").IsRequired(false);
        modelBuilder.Entity<Container>().HasOne(m => m.Owner).WithMany().HasForeignKey("OWNERID").IsRequired(false);
        modelBuilder.Entity<Container>().HasOne(m => m.StartReason).WithMany().HasForeignKey("STARTREASONID").IsRequired(false);
        modelBuilder.Entity<Container>().HasOne(m => m.MfgOrder).WithMany().HasForeignKey("MFGORDERID").IsRequired(false);
        modelBuilder.Entity<Container>().HasOne(m => m.Customer).WithMany().HasForeignKey("CUSTOMERID").IsRequired(false);
        modelBuilder.Entity<Container>().HasOne(m => m.Product).WithMany().HasForeignKey("PRODUCTID").IsRequired(false);
        modelBuilder.Entity<Container>().HasOne(m => m.HoldReason).WithMany().HasForeignKey("HOLDREASONID").IsRequired(false);
        modelBuilder.Entity<Container>().HasOne(m => m.CurrentStatus).WithMany().HasForeignKey("CURRENTSTATUSID").IsRequired(false);
        modelBuilder.Entity<Container>().HasOne(m => m.UOM).WithMany().HasForeignKey("UOMID").IsRequired(false);
        modelBuilder.Entity<Container>().HasOne(m => m.IssuedToContainer).WithMany().HasForeignKey("ISSUEDTOCONTAINERID").IsRequired(false);
        modelBuilder.Entity<Container>().HasOne(m => m.StartParentContainer).WithMany().HasForeignKey("STARTPARENTCONTAINERID").IsRequired(false);
        modelBuilder.Entity<Container>().HasOne(m => m.MfgLine).WithMany().HasForeignKey("MFGLINEID").IsRequired(false);
        modelBuilder.Entity<Container>().HasMany(m => m.Attributes).WithOne().HasForeignKey("PARENTID").IsRequired(false);

        //Employee


        //Enterprise


        //Factory
        modelBuilder.Entity<Factory>().HasOne(m => m.Enterprise).WithMany().HasForeignKey("ENTERPRISEID").IsRequired(false);
        modelBuilder.Entity<Factory>().HasOne(m => m.PrintQueue).WithMany().HasForeignKey("PRINTQUEUEID").IsRequired(false);


        //UserCode


        //ContainerLevel
        

        //Resource
        modelBuilder.Entity<Resource>().HasOne(m => m.ParentResource).WithMany().HasForeignKey("PARENTRESOURCEID").IsRequired(false);
        modelBuilder.Entity<Resource>().HasOne(m => m.Factory).WithMany().HasForeignKey("FACTORYID").IsRequired(false);
        modelBuilder.Entity<Resource>().HasOne(m => m.PrintQueue).WithMany().HasForeignKey("PRINTQUEUEID").IsRequired(false);
        modelBuilder.Entity<Resource>().HasOne(m => m.ResourceFamily).WithMany().HasForeignKey("RESOURCEFAMILYID").IsRequired(false);
        modelBuilder.Entity<Resource>().HasOne(m => m.ResourceType).WithMany().HasForeignKey("RESOURCETYPEID").IsRequired(false);

        
        //WorkCenter
        modelBuilder.Entity<WorkCenter>().HasOne(m => m.ResourceGroup).WithMany().HasForeignKey("RESOURCEGROUPID").IsRequired(false);


        //ObjectGroup


        //Operation
        /*modelBuilder.Entity<Operation>().HasOne(m => m.WorkCenter).WithMany().HasForeignKey("WORKCENTERID").IsRequired(false);
        modelBuilder.Entity<Operation>().HasOne(m => m.LossReasons).WithMany().HasForeignKey("LOSSREASONSID").IsRequired(false);
        modelBuilder.Entity<Operation>().HasOne(m => m.ContainerDefectReasons).WithMany().HasForeignKey("CONTAINERDEFECTREASONSID").IsRequired(false);
        modelBuilder.Entity<Operation>().HasOne(m => m.ThruputReportingLevel).WithMany().HasForeignKey("THRUPUTREPORTINGLEVELID").IsRequired(false);
        modelBuilder.Entity<Operation>().HasOne(m => m.AutoAdjustReason).WithMany().HasForeignKey("AUTOADJUSTREASONID").IsRequired(false);
        modelBuilder.Entity<Operation>().HasOne(m => m.ComponentDefectReasons).WithMany().HasForeignKey("COMPONENTDEFECTREASONSID").IsRequired(false);
        modelBuilder.Entity<Operation>().HasOne(m => m.BuyReasons).WithMany().HasForeignKey("BUYREASONSID").IsRequired(false);
        modelBuilder.Entity<Operation>().HasOne(m => m.QtyAdjustReasons).WithMany().HasForeignKey("QTYADJUSTREASONID").IsRequired(false);
        modelBuilder.Entity<Operation>().HasOne(m => m.PrintQueue).WithMany().HasForeignKey("PRINTQUEUEID").IsRequired(false);*/
        

        //ProductBase
        modelBuilder.Entity<ProductBase>().HasOne(m => m.RevOfRcd).WithMany().HasForeignKey("REVOFRCDID").IsRequired(false);


        //Product
        modelBuilder.Entity<Product>().HasOne(m => m.ProductFamily).WithMany().HasForeignKey("PRODUCTFAMILYID").IsRequired(false);
        modelBuilder.Entity<Product>().HasOne(m => m.ProductType).WithMany().HasForeignKey("PRODUCTTYPEID").IsRequired(false);
        modelBuilder.Entity<Product>().HasOne(m => m.Workflow).WithMany().HasForeignKey("WORKFLOWID").IsRequired(false);
        modelBuilder.Entity<Product>().HasOne(m => m.Customer).WithMany().HasForeignKey("CUSTOMERID").IsRequired(false);
        modelBuilder.Entity<Product>().HasOne(m => m.Base).WithMany().HasForeignKey("PRODUCTBASEID").IsRequired(false);
        modelBuilder.Entity<Product>().HasOne(m => m.StdStartUOM).WithMany().HasForeignKey("STDSTARTUOMID").IsRequired(false);
        modelBuilder.Entity<Product>().HasOne(m => m.StdStartLevel).WithMany().HasForeignKey("STDSTARTLEVELID").IsRequired(false);
        modelBuilder.Entity<Product>().HasOne(m => m.StdStartFactory).WithMany().HasForeignKey("STDSTARTFACTORYID").IsRequired(false);
        modelBuilder.Entity<Product>().HasOne(m => m.StdStartOwner).WithMany().HasForeignKey("STDSTARTOWNERID").IsRequired(false);
        modelBuilder.Entity<Product>().HasOne(m => m.StdStartCustomer).WithMany().HasForeignKey("STDSTARTCUSTOMERID").IsRequired(false);
        modelBuilder.Entity<Product>().HasOne(m => m.StdStartReason).WithMany().HasForeignKey("STDSTARTREASONID").IsRequired(false);

        
        //CurrentStatus
        modelBuilder.Entity<CurrentStatus>().HasOne(m => m.Factory).WithMany().HasForeignKey("FACTORYID").IsRequired(false);
        modelBuilder.Entity<CurrentStatus>().HasOne(m => m.Resource).WithMany().HasForeignKey("RESOURCEID").IsRequired(false);
        modelBuilder.Entity<CurrentStatus>().HasOne(m => m.WorkflowStep).WithMany().HasForeignKey("WORKFLOWSTEPID").IsRequired(false);
        modelBuilder.Entity<CurrentStatus>().HasOne(m => m.Spec).WithMany().HasForeignKey("SPECID").IsRequired(false);

        
        //HistoryMainline
        modelBuilder.Entity<HistoryMainline>().HasOne(m => m.Factory).WithMany().HasForeignKey("FACTORYID").IsRequired(false);
        modelBuilder.Entity<HistoryMainline>().HasOne(m => m.Employee).WithMany().HasForeignKey("EMPLOYEEID").IsRequired(false);
        modelBuilder.Entity<HistoryMainline>().HasOne(m => m.Container).WithMany().HasForeignKey("CONTAINERID").IsRequired(false);
        modelBuilder.Entity<HistoryMainline>().HasOne(m => m.Operation).WithMany().HasForeignKey("OPERATIONID").IsRequired(false);
        modelBuilder.Entity<HistoryMainline>().HasOne(m => m.Resource).WithMany().HasForeignKey("RESOURCEID").IsRequired(false);
        modelBuilder.Entity<HistoryMainline>().HasOne(m => m.Owner).WithMany().HasForeignKey("OWNERID").IsRequired(false);
        modelBuilder.Entity<HistoryMainline>().HasOne(m => m.Product).WithMany().HasForeignKey("PRODUCTID").IsRequired(false);
        modelBuilder.Entity<HistoryMainline>().HasOne(m => m.WorkflowStep).WithMany().HasForeignKey("WORKFLOWSTEPID").IsRequired(false);
        modelBuilder.Entity<HistoryMainline>().HasOne(m => m.Spec).WithMany().HasForeignKey("SPECID").IsRequired(false);
        modelBuilder.Entity<HistoryMainline>().HasOne(m => m.ParentContainer).WithMany().HasForeignKey("PARENTCONTAINERID").IsRequired(false);
        

        //Customer


        //Shift


        //QtyAdjustReason


        //ContainerDefectReason


        //LossReason


        //BuyReason


        //NamedObjectGroup


        //RevisionedObjectGroup


        //ResourceGroup


        //UserCodeGroup


        //LossReasonGroup


        //ContainerDefectReasonGroup


        //IssueReason


        //IssueDifferenceReason


        //ComponentDefectReason


        //ComponentDefectReasonGroup


        //RemovalReason


        //RemoveDifferenceReason


        //BuyReasonGroup


        //QtyAdjustReasonGroup


        //OrderStatus


        //ReleaseReason


        //PrintQueue


        //ReplaceReason


        //ES_NDOs


        //MfgLine


        //Subentity


        //NamedSubentity


        //MfgOrder
        modelBuilder.Entity<MfgOrder>().HasOne(m => m.Product).WithMany().HasForeignKey("PRODUCTID").IsRequired(false);
        modelBuilder.Entity<MfgOrder>().HasOne(m => m.UOM).WithMany().HasForeignKey("UOMID").IsRequired(false);
        modelBuilder.Entity<MfgOrder>().HasOne(m => m.OrderType).WithMany().HasForeignKey("ORDERTYPEID").IsRequired(false);
        modelBuilder.Entity<MfgOrder>().HasOne(m => m.OrderStatus).WithMany().HasForeignKey("ORDERSTATUSID").IsRequired(false);
        modelBuilder.Entity<MfgOrder>().HasOne(m => m.MfgLine).WithMany().HasForeignKey("MFGLINEID").IsRequired(false);
        
        
        //MfgOrderMaterialListItem
        modelBuilder.Entity<MfgOrderMaterialListItem>().HasOne(m => m.RouteStep).WithMany().HasForeignKey("ROUTESTEPID").IsRequired(false);
        modelBuilder.Entity<MfgOrderMaterialListItem>().HasOne(m => m.Product).WithMany().HasForeignKey("PRODUCTID").IsRequired(false);
        modelBuilder.Entity<MfgOrderMaterialListItem>().HasOne(m => m.UOM).WithMany().HasForeignKey("UOMID").IsRequired(false);
        modelBuilder.Entity<MfgOrderMaterialListItem>().HasOne(m => m.Parent).WithMany().HasForeignKey("MFGORDERID").IsRequired(false);
        modelBuilder.Entity<MfgOrderMaterialListItem>().HasOne(m => m.Spec).WithMany().HasForeignKey("SPECID").IsRequired(false);

        
        //UserAttribute
        //modelBuilder.Entity<UserAttribute>().HasOne(m => m.Parent).WithMany().HasForeignKey("PARENTID").IsRequired(false);
        
        
        //NamedDataObject


        //RevisionBase


        //RevisionedObject


        //BaseObject


        //Owner


        //WorkflowBase
        modelBuilder.Entity<WorkflowBase>().HasOne(m => m.RevOfRcd).WithMany().HasForeignKey("REVOFRCDID").IsRequired(false);


        //Workflow
        modelBuilder.Entity<Workflow>().HasOne(m => m.FirstStep).WithMany().HasForeignKey("FIRSTSTEPID").IsRequired(false);
        modelBuilder.Entity<Workflow>().HasOne(m => m.Base).WithMany().HasForeignKey("WORKFLOWBASEID").IsRequired(false);

        
        //SpecBase
        modelBuilder.Entity<SpecBase>().HasOne(m => m.RevOfRcd).WithMany().HasForeignKey("REVOFRCDID").IsRequired(false);


        //Spec
        modelBuilder.Entity<Spec>().HasOne(m => m.Operation).WithMany().HasForeignKey("OPERATIONID").IsRequired(false);
        modelBuilder.Entity<Spec>().HasOne(m => m.ResourceGroup).WithMany().HasForeignKey("RESOURCEGROUPID").IsRequired(false);
        modelBuilder.Entity<Spec>().HasOne(m => m.Base).WithMany().HasForeignKey("SPECBASEID").IsRequired(false);
        modelBuilder.Entity<Spec>().HasOne(m => m.DefaultIssueDifferenceReason).WithMany().HasForeignKey("DEFAULTISSUEDIFFERENCEREASONID").IsRequired(false);
        modelBuilder.Entity<Spec>().HasOne(m => m.MfgLine).WithMany().HasForeignKey("MFGLINEID").IsRequired(false);

       
        //SpecStep
        modelBuilder.Entity<SpecStep>().HasOne(m => m.Spec).WithMany().HasForeignKey("SPECID").IsRequired(false);
        

       //StartReason


       //HoldReason


       //UOM


       //OrderType


       //ResourceFamily


       //ResourceType


       //UserCodeWithWM


       //BusinessProcessWorkflowBase


       //BusinessProcessWorkflow


       //Step


       //BusinessProcessSpecBase


       //BusinessProcessSpec


       //MaterialListItem

       
       //RouteStep


        //ProductFamily


        //ProductType

        /* 
       //ERPMaterialListItem
       */


    }
}
