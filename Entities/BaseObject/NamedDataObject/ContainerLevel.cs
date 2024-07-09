using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. Each container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. Many companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("CONTAINERLEVEL")]
    public class ContainerLevel : NamedDataObject
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("CONTAINERLEVELID")]
        public string? InstanceID { get; set; }

        [Column("CONTAINERLEVELNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<ContainerLevel> ContainerLevels { get; set; }
    }
    public class ContainerLevelEntityTypeConfiguration : IEntityTypeConfiguration<ContainerLevel>
    {
        public void Configure(EntityTypeBuilder<ContainerLevel> builder)
        {

        }
    }
}
