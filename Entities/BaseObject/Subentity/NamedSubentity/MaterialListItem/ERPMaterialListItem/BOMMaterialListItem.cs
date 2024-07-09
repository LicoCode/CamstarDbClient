using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    [Table("BOMMATERIALLISTITEM")]
    public class BOMMaterialListItem : ERPMaterialListItem
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Key]
        [Column("BOMMATERIALLISTITEMID")]
        public string? InstanceID { get; set; }

        [Column("BOMMATERIALLISTITEMNAME")]
        public string? Name { get; set; }
        [ForeignKey("PRODUCTID")]
        public virtual Product? Product { get; set; }
        [Column("QTYREQUIRED")]
        public double? QtyRequired { get; set; }
        [ForeignKey("UOMID")]
        public virtual UOM? UOM { get; set; }

    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<BOMMaterialListItem> BOMMaterialListItems { get; set; }
    }
    public class BOMMaterialListItemEntityTypeConfiguration : IEntityTypeConfiguration<BOMMaterialListItem>
    {
        public void Configure(EntityTypeBuilder<BOMMaterialListItem> builder)
        {

        }
    }
}

