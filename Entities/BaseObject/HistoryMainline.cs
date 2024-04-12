using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description History information  that is common to most or all shop floor transaction services is stored in the HistoryMainline.  Typically there is one HistoryMainline entry for each Shop floor transaction, although compound transactions can be configured to generate multiple HistoryMainlines when appropriate.  The HistoryMainline is the primary source of History information.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("HISTORYMAINLINE")]
    public class HistoryMainline: BaseObject
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [ForeignKey("CONTAINERID")]
        public virtual Container? Container { get; set; }

        [ForeignKey("EMPLOYEEID")]
        public virtual Employee? Employee { get; set; }

        [ForeignKey("FACTORYID")]
        public virtual Factory? Factory { get; set; }

        [Key]
        [Column("HISTORYMAINLINEID")]
        public string? InstanceID { get; set; }

        [ForeignKey("OPERATIONID")]
        public virtual Operation? Operation { get; set; }

        [ForeignKey("OWNERID")]
        public virtual Owner? Owner { get; set; }

        [ForeignKey("RESOURCEID")]
        public virtual Resource? Resource { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<HistoryMainline> HistoryMainlines { get; set; }
    }
    public class HistoryMainlineEntityTypeConfiguration : IEntityTypeConfiguration<HistoryMainline>
    {
        public void Configure(EntityTypeBuilder<HistoryMainline> builder)
        {
            
        }
    }
}
