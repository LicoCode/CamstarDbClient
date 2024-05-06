using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    [Table("T_ECNTYPE")]
    public class T_ECNType : T_NDOs
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Key]
        [Column("T_ECNTYPEID")]
        public string? InstanceID { get; set; }

        [Column("T_ECNTYPENAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

    }
}
namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<T_ECNType> T_ECNTypes { get; set; }
    }
    public class T_ECNTypeConfiguration : IEntityTypeConfiguration<T_ECNType>
    {
        public void Configure(EntityTypeBuilder<T_ECNType> builder)
        {

        }
    }
}