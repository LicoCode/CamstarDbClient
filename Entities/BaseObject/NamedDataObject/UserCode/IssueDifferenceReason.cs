using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description Describes the reason for the difference between the required quantity and the actual quantity issued.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("ISSUEDIFFERENCEREASON")]
    public class IssueDifferenceReason: UserCode
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("ISSUEDIFFERENCEREASONID")]
        public string? InstanceID { get; set; }

        [Column("ISSUEDIFFERENCEREASONNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<IssueDifferenceReason> IssueDifferenceReasons { get; set; }
    }
    public class IssueDifferenceReasonEntityTypeConfiguration : IEntityTypeConfiguration<IssueDifferenceReason>
    {
        public void Configure(EntityTypeBuilder<IssueDifferenceReason> builder)
        {
            
        }
    }
}
