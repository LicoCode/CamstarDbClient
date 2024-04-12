using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. A Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("MFGORDER")]
    public class MfgOrder: NamedDataObject
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [ForeignKey("ERPBOMID")]
        public virtual ERPBOM? ERPBOM { get; set; }

        [Key]
        [Column("MFGORDERID")]
        public string? InstanceID { get; set; }

        [ForeignKey("ISWORKFLOWID")]
        public virtual Workflow? isWorkflow { get; set; }

        public virtual ICollection<MfgOrderMaterialListItem>? MaterialList { get; set; }

        [ForeignKey("MFGLINEID")]
        public virtual MfgLine? MfgLine { get; set; }

        [Column("MFGORDERNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

        [ForeignKey("ORDERSTATUSID")]
        public virtual OrderStatus? OrderStatus { get; set; }

        [ForeignKey("ORDERTYPEID")]
        public virtual OrderType? OrderType { get; set; }

        [Column("QTY")]
        public double? Qty { get; set; }

        [ForeignKey("UOMID")]
        public virtual UOM? UOM { get; set; }
        [ForeignKey("ISWORKFLOWBASEID")]
        public virtual WorkflowBase? isWorkflowBase { get; set; }
    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<MfgOrder> MfgOrders { get; set; }
    }
    public class MfgOrderEntityTypeConfiguration : IEntityTypeConfiguration<MfgOrder>
    {
        public void Configure(EntityTypeBuilder<MfgOrder> builder)
        {
            
        }
    }
}
