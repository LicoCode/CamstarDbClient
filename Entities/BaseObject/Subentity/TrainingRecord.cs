using CamstarDb.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamstarDb.Entities;
using CamstarDb.Entities;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    [Table("TRAININGRECORD")]
    public class TrainingRecord : Subentity
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Key]
        [Column("TRAININGRECORDID")]
        public string? InstanceID { get; set; }

        [ForeignKey("STATUSID")]
        public virtual TrainingRecordStatus? Status { get; set; }

        [ForeignKey("EMPLOYEEID")]
        public virtual Employee? Parent { get; set; }

        [ForeignKey("TRAININGREQUIREMENTID")]
        public virtual TrainingRequirement? TrainingRequirement { get; set; }

    }
}
namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<TrainingRecord> TrainingRecords { get; set; }
    }
    public class TrainingRecordEntityTypeConfiguration : IEntityTypeConfiguration<TrainingRecord>
    {
        public void Configure(EntityTypeBuilder<TrainingRecord> builder)
        {

        }
    }
}

