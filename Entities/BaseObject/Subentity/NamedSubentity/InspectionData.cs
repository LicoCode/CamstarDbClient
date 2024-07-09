using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("INSPECTIONDATA")]
    public class InspectionData : NamedSubentity
    {
        [Column("INSPECTIONNUMBER")]
        public string? InspectionNumber { get; set; }

        [Column("INSPECTIONTIME")]
        public DateTime? InspectionTime { get; set; }

        [Key]
        [Column("INSPECTIONDATAID")]
        public string? InstanceID { get; set; }

        [Column("CHANGECOUNT")]
        public string? ChangeCount { get; set; }

        [ForeignKey("MFGLINEID")]
        public virtual MfgLine? Parent { get; set; }

        [Column("INSPECTIONDATANAME")]
        public string? Name { get; set; }

        [Column("CDOTYPEID")]
        public string? CDOTypeId { get; set; }
    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<InspectionData> InspectionDatas { get; set; }
    }
    public class InspectionDataEntityTypeConfiguration : IEntityTypeConfiguration<InspectionData>
    {
        public void Configure(EntityTypeBuilder<InspectionData> builder)
        {

        }
    }
}