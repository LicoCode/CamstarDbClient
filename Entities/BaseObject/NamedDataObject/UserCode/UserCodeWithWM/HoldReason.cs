using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description Associating a Hold Code with a Container prevents transactions from being performed for that Container. Hold Codes are User Defined to provide multiple descriptions (reasons) for Holds.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("HOLDREASON")]
    public class HoldReason : UserCodeWithWM
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("HOLDREASONID")]
        public string? InstanceID { get; set; }

        [Column("HOLDREASONNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<HoldReason> HoldReasons { get; set; }
    }
    public class HoldReasonEntityTypeConfiguration : IEntityTypeConfiguration<HoldReason>
    {
        public void Configure(EntityTypeBuilder<HoldReason> builder)
        {

        }
    }
}
