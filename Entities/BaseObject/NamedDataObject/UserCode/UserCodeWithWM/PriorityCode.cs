using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description An instance of a Priority Code is one method used to assign a processing priority to a Container. Each Priority Code includes a description and a Relative Priority value. The Relative Priority value is used to sequence Containers for dispatching (independent of the Code name or description). Priority Codes are only one of the algorithms used to determine a numeric value for Scheduling and Dispatching.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("PRIORITYCODE")]
    public class PriorityCode: UserCodeWithWM
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("PRIORITYCODEID")]
        public string? InstanceID { get; set; }

        [Column("PRIORITYCODENAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<PriorityCode> PriorityCodes { get; set; }
    }
    public class PriorityCodeEntityTypeConfiguration : IEntityTypeConfiguration<PriorityCode>
    {
        public void Configure(EntityTypeBuilder<PriorityCode> builder)
        {
            
        }
    }
}
