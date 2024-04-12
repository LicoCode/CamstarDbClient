using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.Optionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("PRODUCTBASE")]
    public class ProductBase: RevisionBase
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Key]
        [Column("PRODUCTBASEID")]
        public string? InstanceID { get; set; }

        [Column("PRODUCTNAME")]
        public string? Name { get; set; }

        public virtual ICollection<Product>? Revisions { get; set; }

        [ForeignKey("REVOFRCDID")]
        public virtual Product? RevOfRcd { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<ProductBase> ProductBases { get; set; }
    }
    public class ProductBaseEntityTypeConfiguration : IEntityTypeConfiguration<ProductBase>
    {
        public void Configure(EntityTypeBuilder<ProductBase> builder)
        {
            builder.HasOne(e => e.RevOfRcd).WithOne().HasForeignKey<ProductBase>("REVOFRCDID").IsRequired(true);
        }
    }
}
