using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description A bill of material (BOM) defines the materials needed to produce a specific product.  An ERP BOM references steps in an ERP route instead of referencing steps in an InSite workflow.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("ERPBOM")]
    public class ERPBOM: Bill
    {
        [ForeignKey("ERPBOMBASEID")]
        public virtual ERPBOMBase? Base { get; set; }

        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("ERPBOMID")]
        public string? InstanceID { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

        [Column("ERPBOMREVISION")]
        public string? Revision { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<ERPBOM> ERPBOMs { get; set; }
    }
    public class ERPBOMEntityTypeConfiguration : IEntityTypeConfiguration<ERPBOM>
    {
        public void Configure(EntityTypeBuilder<ERPBOM> builder)
        {
            
        }
    }
}
