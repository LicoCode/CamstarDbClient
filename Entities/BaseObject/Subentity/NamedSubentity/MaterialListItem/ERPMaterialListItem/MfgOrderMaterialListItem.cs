using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description Represents a particular material that is required to complete a given manufacturing or assembly step, as defined by the ERP RouteStep refenced in the current WorkflowStep of the container.  The necessary quantities or proportions of the item are specified as are the appropriate units of measure.  This particular type of material list item is used on Mfg orders, and was created so that MfgOrder component lists could be stored in a separate table from BOM or Container component lists.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("MFGORDERMATERIALLISTITEM")]
    public class MfgOrderMaterialListItem: ERPMaterialListItem
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Key]
        [Column("MFGORDERMATERIALLISTITEMID")]
        public string? InstanceID { get; set; }

        [Column("MFGORDERMATERIALLISTITEMNAME")]
        public string? Name { get; set; }
        [ForeignKey("PRODUCTID")]
        public virtual Product? Product { get; set; }
        [Column("QTYREQUIRED")]
        public double? QtyRequired { get; set; }
        [ForeignKey("UOMID")]
        public virtual UOM? UOM { get; set; }
    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<MfgOrderMaterialListItem> MfgOrderMaterialListItems { get; set; }
    }
    public class MfgOrderMaterialListItemEntityTypeConfiguration : IEntityTypeConfiguration<MfgOrderMaterialListItem>
    {
        public void Configure(EntityTypeBuilder<MfgOrderMaterialListItem> builder)
        {
            
        }
    }
}
