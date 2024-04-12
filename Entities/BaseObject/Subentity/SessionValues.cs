using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description Session Values are used to determine default values. An instance is associated with each User defined to the application (that can log-in). At login the values are copied for use by that session. Values can be modified during the session and saved or discarded when the session completes If they are saved, the updated values will be used for initialization at the next log-in (for that User).
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("SESSIONVALUES")]
    public class SessionValues: Subentity
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [ForeignKey("FACTORYID")]
        public virtual Factory? Factory { get; set; }

        [Key]
        [Column("SESSIONVALUESID")]
        public string? InstanceID { get; set; }

        [ForeignKey("WORKCENTERID")]
        public virtual WorkCenter? WorkCenter { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<SessionValues> SessionValuess { get; set; }
    }
    public class SessionValuesEntityTypeConfiguration : IEntityTypeConfiguration<SessionValues>
    {
        public void Configure(EntityTypeBuilder<SessionValues> builder)
        {
            
        }
    }
}
