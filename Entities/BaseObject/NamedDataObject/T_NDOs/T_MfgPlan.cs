using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description Manufacturing Planning: which work orders are planned to be produced in a specified time period, as well as the current production status, including the quantity completed, the planned production quantity
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("T_MFGPLAN")]
    public class T_MfgPlan: T_NDOs
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("T_MFGPLANID")]
        public string? InstanceID { get; set; }

        [Column("MFGDATE")]
        public DateTime? MfgDate { get; set; }

        [Column("T_MFGPLANNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

        public virtual ICollection<T_PlanDetail>? T_PlanDetail { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<T_MfgPlan> T_MfgPlans { get; set; }
    }
    public class T_MfgPlanEntityTypeConfiguration : IEntityTypeConfiguration<T_MfgPlan>
    {
        public void Configure(EntityTypeBuilder<T_MfgPlan> builder)
        {
            
        }
    }
}
