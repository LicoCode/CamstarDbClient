using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description A Specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.A Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("SPECBASE")]
    public class SpecBase : BusinessProcessSpecBase
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Key]
        [Column("SPECBASEID")]
        public string? InstanceID { get; set; }

        [Column("SPECNAME")]
        public string? Name { get; set; }

        public virtual ICollection<Spec>? Revisions { get; set; }

        [ForeignKey("REVOFRCDID")]
        public virtual Spec? RevOfRcd { get; set; }

    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<SpecBase> SpecBases { get; set; }
    }
    public class SpecBaseEntityTypeConfiguration : IEntityTypeConfiguration<SpecBase>
    {
        public void Configure(EntityTypeBuilder<SpecBase> builder)
        {
            builder.HasOne(e => e.RevOfRcd).WithOne().HasForeignKey<SpecBase>("REVOFRCDID").IsRequired(true);
        }
    }
}
