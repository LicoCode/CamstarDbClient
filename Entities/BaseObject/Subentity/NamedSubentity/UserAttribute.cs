using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description A user attribute is used to record a single value, identified by a unique name and attached to an object as a list.  This is different from a set of single fields because the attributes can be different based on many factors, such as product or factory.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("USERATTRIBUTE")]
    public class UserAttribute: NamedSubentity
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Key]
        [Column("USERATTRIBUTEID")]
        public string? InstanceID { get; set; }

        [Column("USERATTRIBUTENAME")]
        public string? Name { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<UserAttribute> UserAttributes { get; set; }
    }
    public class UserAttributeEntityTypeConfiguration : IEntityTypeConfiguration<UserAttribute>
    {
        public void Configure(EntityTypeBuilder<UserAttribute> builder)
        {
            
        }
    }
}
