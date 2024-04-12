using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.A Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.See the Operation Definition for Scheduling Details information.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("SPEC")]
    public class Spec: BusinessProcessSpec
    {

        public virtual SpecBase? Base { get; set; }

        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("SPECID")]
        public string? InstanceID { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

        [Column("SPECREVISION")]
        public string? Revision { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<Spec> Specs { get; set; }
    }
    public class SpecEntityTypeConfiguration : IEntityTypeConfiguration<Spec>
    {
        public void Configure(EntityTypeBuilder<Spec> builder)
        {
            builder.HasOne(e => e.Base).WithMany(e => e.Revisions).HasForeignKey("SPECBASEID").IsRequired(true);
        }
    }
}
