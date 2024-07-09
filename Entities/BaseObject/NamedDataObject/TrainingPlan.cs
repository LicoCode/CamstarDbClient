using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description A training plan defines a schedule of training requirements (certifications) and target dates for when employees should be trained on the listed requirement.  Training plans can also be used as components in larger training plans.
    ///    @author lichong
    ///    @date 2024/5/20
    [Table("TRAININGPLAN")]
    public class TrainingPlan : NamedDataObject
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("TRAININGPLANID")]
        public string? InstanceID { get; set; }

        [Column("TRAININGPLANNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<TrainingPlan> TrainingPlans { get; set; }
    }
    public class TrainingPlanEntityTypeConfiguration : IEntityTypeConfiguration<TrainingPlan>
    {
        public void Configure(EntityTypeBuilder<TrainingPlan> builder)
        {

        }
    }
}
