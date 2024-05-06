using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description Plan details
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("T_PLANDETAIL")]
    public class T_PlanDetail: NamedSubentity
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("COMPLETEDQTY")]
        public double? CompletedQty { get; set; }

        [Key]
        [Column("T_PLANDETAILID")]
        public string? InstanceID { get; set; }

        [ForeignKey("MFGLINEID")]
        public virtual MfgLine? MfgLine { get; set; }

        [ForeignKey("MFGORDERID")]
        public virtual MfgOrder? MfgOrder { get; set; }

        [Column("T_PLANDETAILNAME")]
        public string? Name { get; set; }

        [ForeignKey("T_MFGPLANID")]
        public virtual T_MfgPlan? Parent { get; set; }

        [Column("PLANENDTIME")]
        public DateTime? PlanEndTime { get; set; }

        [Column("PLANNEDQTY")]
        public double? PlannedQty { get; set; }

        [Column("PLANSTARTTIME")]
        public DateTime? PlanStartTime { get; set; }

        [ForeignKey("T_PLANSTATUSID")]
        public virtual T_PlanStatus? T_PlanStatus { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<T_PlanDetail> T_PlanDetails { get; set; }
    }
    public class T_PlanDetailEntityTypeConfiguration : IEntityTypeConfiguration<T_PlanDetail>
    {
        public void Configure(EntityTypeBuilder<T_PlanDetail> builder)
        {
            
        }
    }
}
