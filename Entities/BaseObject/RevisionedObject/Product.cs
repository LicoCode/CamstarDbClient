using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.Optionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("PRODUCT")]
    public class Product: RevisionedObject
    {
        public virtual ProductBase? Base { get; set; }

        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [ForeignKey("CUSTOMERID")]
        public virtual Customer? Customer { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [ForeignKey("ERPBOMID")]
        public virtual ERPBOM? ERPBOM { get; set; }

        [Key]
        [Column("PRODUCTID")]
        public string? InstanceID { get; set; }

        [Column("ISPHANTOM")]
        public bool? IsPhantom { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

        [ForeignKey("PRODUCTFAMILYID")]
        public virtual ProductFamily? ProductFamily { get; set; }

        [ForeignKey("PRODUCTTYPEID")]
        public virtual ProductType? ProductType { get; set; }

        [Column("PRODUCTREVISION")]
        public string? Revision { get; set; }

        [ForeignKey("STDSTARTCUSTOMERID")]
        public virtual Customer? StdStartCustomer { get; set; }

        [ForeignKey("STDSTARTFACTORYID")]
        public virtual Factory? StdStartFactory { get; set; }

        [ForeignKey("STDSTARTLEVELID")]
        public virtual ContainerLevel? StdStartLevel { get; set; }

        [ForeignKey("STDSTARTOWNERID")]
        public virtual Owner? StdStartOwner { get; set; }

        [ForeignKey("STDSTARTPRIORITYCODEID")]
        public virtual PriorityCode? StdStartPriorityCode { get; set; }

        [Column("STDSTARTQTY")]
        public double? StdStartQty { get; set; }

        [ForeignKey("STDSTARTREASONID")]
        public virtual StartReason? StdStartReason { get; set; }

        [ForeignKey("STDSTARTUOMID")]
        public virtual UOM? StdStartUOM { get; set; }
        

        [ForeignKey("WORKFLOWID")]
        public virtual Workflow? Workflow { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<Product> Products { get; set; }
    }
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasOne(e => e.Base).WithMany(e => e.Revisions).HasForeignKey("PRODUCTBASEID").IsRequired(true);
        }
    }
}
