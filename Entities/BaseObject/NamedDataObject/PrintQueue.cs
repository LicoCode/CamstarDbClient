using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description Printers InSite can use to print labels.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("PRINTQUEUE")]
    public class PrintQueue: NamedDataObject
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("PRINTQUEUEID")]
        public string? InstanceID { get; set; }

        [Column("PRINTQUEUENAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<PrintQueue> PrintQueues { get; set; }
    }
    public class PrintQueueEntityTypeConfiguration : IEntityTypeConfiguration<PrintQueue>
    {
        public void Configure(EntityTypeBuilder<PrintQueue> builder)
        {
            
        }
    }
}
