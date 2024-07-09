using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description A bill of material (BOM) defines the materials needed to produce a specific product.  An ERP BOM references steps in an ERP route instead of referencing steps in an InSite workflow.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("ERPBOMBASE")]
    public class ERPBOMBase : BillBase
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Key]
        [Column("ERPBOMBASEID")]
        public string? InstanceID { get; set; }

        [Column("ERPBOMNAME")]
        public string? Name { get; set; }

    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<ERPBOMBase> ERPBOMBases { get; set; }
    }
    public class ERPBOMBaseEntityTypeConfiguration : IEntityTypeConfiguration<ERPBOMBase>
    {
        public void Configure(EntityTypeBuilder<ERPBOMBase> builder)
        {

        }
    }
}
