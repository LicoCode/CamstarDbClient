using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description NamedObjectGroup is used to provide a list of named object.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("NAMEDOBJECTGROUP")]
    public class NamedObjectGroup: ObjectGroup
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("NAMEDOBJECTGROUPID")]
        public string? InstanceID { get; set; }

        [Column("NAMEDOBJECTGROUPNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<NamedObjectGroup> NamedObjectGroups { get; set; }
    }
    public class NamedObjectGroupEntityTypeConfiguration : IEntityTypeConfiguration<NamedObjectGroup>
    {
        public void Configure(EntityTypeBuilder<NamedObjectGroup> builder)
        {
            
        }
    }
}
