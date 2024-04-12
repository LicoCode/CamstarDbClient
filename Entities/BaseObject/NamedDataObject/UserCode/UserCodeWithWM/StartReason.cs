using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description Each Container has an associated Start Code. Start Codes are available for selection criteria on WIP Status Inquiries and for transaction reporting (based on the transaction history).
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("STARTREASON")]
    public class StartReason: UserCodeWithWM
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("STARTREASONID")]
        public string? InstanceID { get; set; }

        [Column("STARTREASONNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<StartReason> StartReasons { get; set; }
    }
    public class StartReasonEntityTypeConfiguration : IEntityTypeConfiguration<StartReason>
    {
        public void Configure(EntityTypeBuilder<StartReason> builder)
        {
            
        }
    }
}
