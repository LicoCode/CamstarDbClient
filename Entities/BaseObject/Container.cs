using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).
    ///    @author lichong 
    ///    @date 2024/4/12
    [Table("CONTAINER")]
    public class Container : BaseObject
    {
        [ForeignKey("PARENTID")]
        public virtual ICollection<UserAttribute>? Attributes { get; set; }

        [Column("ES_PRIMARYSERIALNUMBER")]
        public string? ES_PrimarySerialNumber { get; set; }
        [Column("ES_SERIALNUMBER2")]
        public string? ES_SerialNumber2 { get; set; }
        [Column("ES_SERIALNUMBER3")]
        public string? ES_SerialNumber3 { get; set; }

        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [ForeignKey("CURRENTSTATUSID")]
        public virtual CurrentStatus? CurrentStatus { get; set; }

        [ForeignKey("CUSTOMERID")]
        public virtual Customer? Customer { get; set; }

        [ForeignKey("HOLDREASONID")]
        public virtual HoldReason? HoldReason { get; set; }

        [Key]
        [Column("CONTAINERID")]
        public string? InstanceID { get; set; }

        [ForeignKey("LEVELID")]
        public virtual ContainerLevel? Level { get; set; }

        [ForeignKey("MFGLINEID")]
        public virtual MfgLine? MfgLine { get; set; }

        [ForeignKey("MFGORDERID")]
        public virtual MfgOrder? MfgOrder { get; set; }

        [Column("CONTAINERNAME")]
        public string? Name { get; set; }

        [ForeignKey("OWNERID")]
        public virtual Owner? Owner { get; set; }

        [ForeignKey("PARENTCONTAINERID")]
        public virtual Container? Parent { get; set; }

        [ForeignKey("PRODUCTID")]
        public virtual Product? Product { get; set; }

        [Column("QTY")]
        public double? Qty { get; set; }

        [Column("STATUS")]
        public ContainerStatusEnum? Status { get; set; }

        [ForeignKey("UOMID")]
        public virtual UOM? UOM { get; set; }
        public virtual ICollection<Container>? ChildContainers { get; set; }

    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<Container> Containers { get; set; }
    }
    public class ContainerEntityTypeConfiguration : IEntityTypeConfiguration<Container>
    {
        public void Configure(EntityTypeBuilder<Container> builder)
        {
            builder.HasOne(e => e.Parent).WithMany(e => e.ChildContainers).HasForeignKey("PARENTCONTAINERID").IsRequired(false);

        }
    }
}
