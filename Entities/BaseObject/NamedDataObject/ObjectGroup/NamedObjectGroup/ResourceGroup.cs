using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description A Named Object Group that represents a group of Resources.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("RESOURCEGROUP")]
    public class ResourceGroup : NamedObjectGroup
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        public virtual ICollection<Resource>? Entries { get; set; }

        public virtual ICollection<ResourceGroup>? Groups { get; set; }

        [Key]
        [Column("RESOURCEGROUPID")]
        public string? InstanceID { get; set; }

        [Column("RESOURCEGROUPNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }
        public virtual ICollection<ResourceGroup> ResourceGroups { get; set; }
    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<ResourceGroup> ResourceGroups { get; set; }
    }
    public class ResourceGroupEntityTypeConfiguration : IEntityTypeConfiguration<ResourceGroup>
    {
        public void Configure(EntityTypeBuilder<ResourceGroup> builder)
        {
            builder
.HasMany(e => e.Entries)
.WithMany(e => e.ResourceGroups)
.UsingEntity<Dictionary<string, object>>(
"RESOURCEGROUPENTRIES",
l => l.HasOne<Resource>().WithMany().HasForeignKey("ENTRIESID"),
r => r.HasOne<ResourceGroup>().WithMany().HasForeignKey("RESOURCEGROUPID"),
j =>
{
    j.HasKey("RESOURCEGROUPID", "ENTRIESID");

}
);
            builder
        .HasMany(e => e.Groups)
        .WithMany(e => e.ResourceGroups)
        .UsingEntity<Dictionary<string, object>>(
            "RESOURCEGROUPGROUPS",
            l => l.HasOne<ResourceGroup>().WithMany().HasForeignKey("GROUPSID"),
            r => r.HasOne<ResourceGroup>().WithMany().HasForeignKey("RESOURCEGROUPID"),
            j =>
            {
                j.HasKey("RESOURCEGROUPID", "GROUPSID");

            }
        );

        }
    }
}
