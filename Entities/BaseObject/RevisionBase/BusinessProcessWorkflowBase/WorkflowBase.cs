using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description The RevisionBase holds information common to all revisions of an object, plus information on which revision is the revision of record.  WorkflowBase is the specific type of RevisionBase used for a workflow, which defines the route and processing details required for a manufacturing process.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("WORKFLOWBASE")]
    public class WorkflowBase : BusinessProcessWorkflowBase
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Key]
        [Column("WORKFLOWBASEID")]
        public string? InstanceID { get; set; }

        [Column("WORKFLOWNAME")]
        public string? Name { get; set; }

        public virtual ICollection<Workflow>? Revisions { get; set; }

        [ForeignKey("REVOFRCDID")]
        public virtual Workflow? RevOfRcd { get; set; }

    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<WorkflowBase> WorkflowBases { get; set; }
    }
    public class WorkflowBaseEntityTypeConfiguration : IEntityTypeConfiguration<WorkflowBase>
    {
        public void Configure(EntityTypeBuilder<WorkflowBase> builder)
        {

        }
    }
}
