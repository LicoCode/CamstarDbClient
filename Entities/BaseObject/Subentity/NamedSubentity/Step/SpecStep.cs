using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.A sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.A Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("WORKFLOWSTEP")]
    public class SpecStep: Step
    {
        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Column("WORKFLOWSTEPNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }
        [Key()]
        [Column("WORKFLOWSTEPID")]
        public string? InstanceID { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<SpecStep> SpecSteps { get; set; }
    }
    public class SpecStepEntityTypeConfiguration : IEntityTypeConfiguration<SpecStep>
    {
        public void Configure(EntityTypeBuilder<SpecStep> builder)
        {
            
        }
    }
}
