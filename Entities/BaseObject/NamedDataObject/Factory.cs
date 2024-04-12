using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. 
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("FACTORY")]
    public class Factory: NamedDataObject
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [ForeignKey("ENTERPRISEID")]
        public virtual Enterprise? Enterprise { get; set; }

        [Key]
        [Column("FACTORYID")]
        public string? InstanceID { get; set; }

        [Column("FACTORYNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

        [ForeignKey("PRINTQUEUEID")]
        public virtual PrintQueue? PrintQueue { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<Factory> Factorys { get; set; }
    }
    public class FactoryEntityTypeConfiguration : IEntityTypeConfiguration<Factory>
    {
        public void Configure(EntityTypeBuilder<Factory> builder)
        {
            
        }
    }
}
