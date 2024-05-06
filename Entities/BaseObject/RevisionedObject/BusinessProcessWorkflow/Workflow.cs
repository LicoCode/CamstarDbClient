using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. A Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("WORKFLOW")]
    public class Workflow: BusinessProcessWorkflow
    {
        public virtual WorkflowBase? Base { get; set; }

        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [ForeignKey("FIRSTSTEPID")]
        public virtual Step? FirstStep { get; set; }

        [Key]
        [Column("WORKFLOWID")]
        public string? InstanceID { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

        [Column("WORKFLOWREVISION")]
        public string? Revision { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<Workflow> Workflows { get; set; }
    }
    public class WorkflowEntityTypeConfiguration : IEntityTypeConfiguration<Workflow>
    {
        public void Configure(EntityTypeBuilder<Workflow> builder)
        {
            builder.HasOne(e => e.Base).WithMany(e => e.Revisions).HasForeignKey("WORKFLOWBASEID").IsRequired(true);
        }
    }
}
