using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description Resource Family is used to differentiate between types of Resources such as Testers and Handlers.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("RESOURCEFAMILY")]
    public class ResourceFamily : NamedDataObject
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("RESOURCEFAMILYID")]
        public string? InstanceID { get; set; }

        [Column("RESOURCEFAMILYNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<ResourceFamily> ResourceFamilys { get; set; }
    }
    public class ResourceFamilyEntityTypeConfiguration : IEntityTypeConfiguration<ResourceFamily>
    {
        public void Configure(EntityTypeBuilder<ResourceFamily> builder)
        {

        }
    }
}
