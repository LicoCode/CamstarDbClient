using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    [Table("T_PLANITEM")]
    public class T_PlanItem : NamedSubentity
    {
        [Key]
        [Column("T_PLANITEMID")]
        public string? InstanceID { get; set; }

        [Column("MFGDATE")]
        public DateTime? MfgDate { get; set; }

        [Column("COMPLETEDQTY")]
        public double? CompletedQty { get; set; }

        [Column("PLANNEDQTY")]
        public double? PlannedQty { get; set; }

        [ForeignKey("T_PLANSTATUSID")]
        public virtual T_PlanStatus? T_PlanStatus { get; set; }

        [ForeignKey("MFGORDERID")]
        public virtual MfgOrder? Parent { get; set; }

        [ForeignKey("MFGLINEID")]
        public virtual MfgLine? MfgLine { get; set; }

        [Column("T_PLANITEMNAME")]
        public string? Name { get; set; }

        [Column("CHANGECOUNT")]
        public string? ChangeCount {  get; set; }


        [Column("CDOTYPEID")]
        public string? CDOTypeId { get; set; }

        [Column("PREPRODUCTIONCOMFIRMED")]
        public Boolean? PreProductionComfirmed { get; set; }
    }
}
namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<T_PlanItem> T_PlanItems { get; set; }
    }
    public class T_PlanItemEntityTypeConfiguration : IEntityTypeConfiguration<T_PlanItem>
    {
        public void Configure(EntityTypeBuilder<T_PlanItem> builder)
        {

        }
    }
}