using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description Resource Type, a Resource categorization.  Resources with the same Resource Type may share the same Resources Status Model.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("RESOURCETYPE")]
    public class ResourceType: UserCode
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("RESOURCETYPEID")]
        public string? InstanceID { get; set; }

        [Column("RESOURCETYPENAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<ResourceType> ResourceTypes { get; set; }
    }
    public class ResourceTypeEntityTypeConfiguration : IEntityTypeConfiguration<ResourceType>
    {
        public void Configure(EntityTypeBuilder<ResourceType> builder)
        {
            
        }
    }
}
