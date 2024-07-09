using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CamstarDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CamstarDb.Entities
{
    ///    @Description Manufacturing Line is used to represent the line where containers are being processed. It can be assigned to Spec, Resource, Container and Mfg Order. It is used during manufacturing line verification when a container start production or more accurately moves out of a Spec with its Verify Mfg Line set to true. The Container's Mfg Line will be taken from its own Mfg Line field, Mfg Order's Mfg Line or the current Spec's Mfg Line. Once determined the verification will check all steps within the Container's Workflow with the same Mfg Line.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("A_MFGLINE")]
    public class MfgLine : ES_NDOs
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("MFGLINEID")]
        public string? InstanceID { get; set; }

        [Column("MFGLINENAME")]
        public string? Name { get; set; }

        [Column("NUMBEROFINSPECTION")]
        public int? Numberofinspection { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

        [ForeignKey("WORKCENTERID")]
        public virtual WorkCenter? WorkCenter { get; set; }
        public virtual ICollection<ProductionStatus>? ProductionStatuses { get; set; }
    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<MfgLine> MfgLines { get; set; }
    }
    public class MfgLineEntityTypeConfiguration : IEntityTypeConfiguration<MfgLine>
    {
        public void Configure(EntityTypeBuilder<MfgLine> builder)
        {

        }
    }
}
