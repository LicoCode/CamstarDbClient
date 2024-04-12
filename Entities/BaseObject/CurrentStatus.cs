using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description The Current Container Status contains the current location information for one or more containers.  Every container associated in a multilevel container structure will have a reference to a single Current Container Status CDO.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("CURRENTSTATUS")]
    public class CurrentStatus: BaseObject
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [ForeignKey("FACTORYID")]
        public virtual Factory? Factory { get; set; }

        [Key]
        [Column("CURRENTSTATUSID")]
        public string? InstanceID { get; set; }

        [ForeignKey("RESOURCEID")]
        public virtual Resource? Resource { get; set; }

        [ForeignKey("SPECID")]
        public virtual Spec? Spec { get; set; }

        [ForeignKey("WORKFLOWSTEPID")]
        public virtual SpecStep? WorkflowStep { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<CurrentStatus> CurrentStatuss { get; set; }
    }
    public class CurrentStatusEntityTypeConfiguration : IEntityTypeConfiguration<CurrentStatus>
    {
        public void Configure(EntityTypeBuilder<CurrentStatus> builder)
        {
            
        }
    }
}
