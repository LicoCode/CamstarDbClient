using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description The Enterprise refers to the highest level in the factory definition. The Enterprise can represent the company itself, or a large division of the company. An Enterprise can contain one or more factories.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("ENTERPRISE")]
    public class Enterprise : NamedDataObject
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("ENTERPRISEID")]
        public string? InstanceID { get; set; }

        [Column("ENTERPRISENAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<Enterprise> Enterprises { get; set; }
    }
    public class EnterpriseEntityTypeConfiguration : IEntityTypeConfiguration<Enterprise>
    {
        public void Configure(EntityTypeBuilder<Enterprise> builder)
        {

        }
    }
}
