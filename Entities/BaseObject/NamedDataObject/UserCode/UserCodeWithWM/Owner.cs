using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description Every Container has an associated Owner Code. The owner code is used as a grouping to separate Containers for inquiry and processing. Examples of Owner Code are "Manufacturing", "Engineering", "Prototypes", "SalesSamples", etc.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("OWNER")]
    public class Owner: UserCodeWithWM
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("OWNERID")]
        public string? InstanceID { get; set; }

        [Column("OWNERNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<Owner> Owners { get; set; }
    }
    public class OwnerEntityTypeConfiguration : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            
        }
    }
}
