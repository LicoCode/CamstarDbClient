using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Each Product can belong to a Product Family. Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.Product Families are a slightly different concept from object groups. Grouping (Product bases, Operations, Resources, etc.) is done for validation and reporting. Groups are more free form and the application has less concrete knowledge of Groups (than Product Families). Another differentiation is that one object can belong to multiple Groups, but a product can only belong to one Product Family. Finally, Groups can contain other (sub-) Groups. Product Families can only contain Products.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("PRODUCTFAMILY")]
    public class ProductFamily: NamedDataObject
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("PRODUCTFAMILYID")]
        public string? InstanceID { get; set; }

        [Column("PRODUCTFAMILYNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<ProductFamily> ProductFamilys { get; set; }
    }
    public class ProductFamilyEntityTypeConfiguration : IEntityTypeConfiguration<ProductFamily>
    {
        public void Configure(EntityTypeBuilder<ProductFamily> builder)
        {
            
        }
    }
}
