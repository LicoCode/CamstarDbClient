using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description The Current Container Status contains the current location information for one or more containers.  Every container associated in a multilevel container structure will have a reference to a single Current Container Status CDO.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("CURRENTSTATUS")]
    public class CurrentStatus : BaseObject
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

        [Column("ISWORKFLOWNAME")]
        public string? isWorkflowName { get; set; }

        [ForeignKey("RESOURCEID")]
        public virtual Resource? Resource { get; set; }

        [ForeignKey("SPECID")]
        public virtual Spec? Spec { get; set; }

        public virtual SpecStep? WorkflowStep { get; set; }

        [Column("MOVEINDATE")]
        public DateTime? MoveInDate { get; set; }

        [Column("INREWORK")]
        public bool? InRework { get; set; }

    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<CurrentStatus> CurrentStatuss { get; set; }
    }
    public class CurrentStatusEntityTypeConfiguration : IEntityTypeConfiguration<CurrentStatus>
    {
        public void Configure(EntityTypeBuilder<CurrentStatus> builder)
        {
            builder.HasOne(e => e.WorkflowStep).WithMany().HasForeignKey("WORKFLOWSTEPID").IsRequired(true);
        }
    }
}
