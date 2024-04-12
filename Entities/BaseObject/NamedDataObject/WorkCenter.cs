using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description A work center is typically an area where work of a similar nature is performed.  A work Center contains zero or more operations.The work center is the component through which scheduling is performed through InSite. Scheduling can be conducted according to either employees or resources.  A work center may have multiple operations if the operations are sharing employees, resources, or both. For example, an operation called Grind and an operation called Polish both use the same resources so they point to the same work center for scheduling purposes. There can also be one operation to one work center.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("WORKCENTER")]
    public class WorkCenter: NamedDataObject
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("WORKCENTERID")]
        public string? InstanceID { get; set; }

        [Column("WORKCENTERNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

        [ForeignKey("RESOURCEGROUPID")]
        public virtual ResourceGroup? ResourceGroup { get; set; }
        public virtual ICollection<MfgLine>? MfgLines { get; set; }
    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<WorkCenter> WorkCenters { get; set; }
    }
    public class WorkCenterEntityTypeConfiguration : IEntityTypeConfiguration<WorkCenter>
    {
        public void Configure(EntityTypeBuilder<WorkCenter> builder)
        {
            
        }
    }
}
