using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description The user code for unit of material.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("UOM")]
    public class UOM: UserCodeWithWM
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("UOMID")]
        public string? InstanceID { get; set; }

        [Column("UOMNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<UOM> UOMs { get; set; }
    }
    public class UOMEntityTypeConfiguration : IEntityTypeConfiguration<UOM>
    {
        public void Configure(EntityTypeBuilder<UOM> builder)
        {
            
        }
    }
}
