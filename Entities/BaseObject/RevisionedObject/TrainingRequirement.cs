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
    [Table("TRAININGREQUIREMENT")]
    public class TrainingRequirement : RevisionedObject
    {
        public virtual ICollection<TrainingReqGroup>? TrainingReqGroups { get; set; }

        [Column("TRAININGREQUIREMENTBASEID")]
        public virtual TrainingRequirementBase? Base { get; set; }

        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("TRAININGREQUIREMENTID")]
        public string? InstanceID { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

        [Column("TRAININGREQUIREMENTREVISION")]
        public string? Revision { get; set; }

    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<TrainingRequirement> TrainingRequirements { get; set; }
    }
    public class TrainingRequirementEntityTypeConfiguration : IEntityTypeConfiguration<TrainingRequirement>
    {
        public void Configure(EntityTypeBuilder<TrainingRequirement> builder)
        {
            builder.HasOne(e => e.Base).WithMany(e => e.Revisions).HasForeignKey("TRAININGREQUIREMENTBASEID").IsRequired(true);

        }
    }
}
