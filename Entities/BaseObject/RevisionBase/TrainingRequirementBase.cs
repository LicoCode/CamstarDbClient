using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description Definition of the training required before a user is allowed to perform a specific task
    ///    @author lichong
    ///    @date 2024/5/20
    [Table("TRAININGREQUIREMENTBASE")]
    public class TrainingRequirementBase : RevisionBase
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Key]
        [Column("TRAININGREQUIREMENTBASEID")]
        public string? InstanceID { get; set; }

        [Column("TRAININGREQUIREMENTNAME")]
        public string? Name { get; set; }

        public virtual ICollection<TrainingRequirement>? Revisions { get; set; }

        [Column("REVOFRCDID")]
        public virtual TrainingRequirement? RevOfRcd { get; set; }

    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<TrainingRequirementBase> TrainingRequirementBases { get; set; }
    }
    public class TrainingRequirementBaseEntityTypeConfiguration : IEntityTypeConfiguration<TrainingRequirementBase>
    {
        public void Configure(EntityTypeBuilder<TrainingRequirementBase> builder)
        {
            builder.HasOne(e => e.RevOfRcd).WithOne().HasForeignKey<TrainingRequirementBase>("REVOFRCDID").IsRequired(true);

        }
    }
}
