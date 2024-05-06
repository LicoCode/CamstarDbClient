using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description An instance of a Resource Production Status is used to keep track of the current status of a Resource (typically a machine) as it relates to production. This includes information such as whether the Resource is Up (available) or Down, what Product(s) it is currently setup to run, the currently associated manufacturing order (if any), etc. A Resource Production Status can be thought of as the Resource view of production in contrast to a Container being the material view of production.
    ///    @author lichong
    ///    @date 2024/4/22
    [Table("PRODUCTIONSTATUS")]
    public class ProductionStatus: CurrentResourceStatus
    {
        [Column("AVAILABILITY")]
        public ResourceAvailabilityEnum? Availability { get; set; }

        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [ForeignKey("MFGLINEID")]
        public virtual MfgLine? MfgLine { get; set; }
        [ForeignKey("RESOURCEID")]
        public virtual Resource? Parent { get; set; }

        [Key]
        [Column("PRODUCTIONSTATUSID")]
        public string? InstanceID { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<ProductionStatus> ProductionStatuss { get; set; }
    }
    public class ProductionStatusEntityTypeConfiguration : IEntityTypeConfiguration<ProductionStatus>
    {
        public void Configure(EntityTypeBuilder<ProductionStatus> builder)
        {
            
        }
    }
}
