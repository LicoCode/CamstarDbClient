using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description ERP Manufaturing Order type.  Several different values that can appear here include: "Standard", "Rework", "Test Run", etc
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("ORDERTYPE")]
    public class OrderType: UserCode
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("ORDERTYPEID")]
        public string? InstanceID { get; set; }

        [Column("ORDERTYPENAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<OrderType> OrderTypes { get; set; }
    }
    public class OrderTypeEntityTypeConfiguration : IEntityTypeConfiguration<OrderType>
    {
        public void Configure(EntityTypeBuilder<OrderType> builder)
        {
            
        }
    }
}
