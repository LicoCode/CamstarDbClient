using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description Plan Status
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("T_PLANSTATUS")]
    public class T_PlanStatus: T_NDOs
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("T_PLANSTATUSID")]
        public string? InstanceID { get; set; }

        [Column("T_PLANSTATUSNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<T_PlanStatus> T_PlanStatuss { get; set; }
    }
    public class T_PlanStatusEntityTypeConfiguration : IEntityTypeConfiguration<T_PlanStatus>
    {
        public void Configure(EntityTypeBuilder<T_PlanStatus> builder)
        {
            
        }
    }
}
