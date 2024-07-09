using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.The Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. 
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("OPERATION")]
    public class Operation : NamedDataObject
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("OPERATIONID")]
        public string? InstanceID { get; set; }

        [Column("OPERATIONNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

        [ForeignKey("REWORKREASONSID")]
        public virtual ReworkReasonGroup? ReworkReasons { get; set; }

        [ForeignKey("PRINTQUEUEID")]
        public virtual PrintQueue? PrintQueue { get; set; }
    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<Operation> Operations { get; set; }
    }
    public class OperationEntityTypeConfiguration : IEntityTypeConfiguration<Operation>
    {
        public void Configure(EntityTypeBuilder<Operation> builder)
        {

        }
    }
}
