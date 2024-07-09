using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description A Resource Status Code is provides a description of the current availability for a Resource. This value is used for inquiry and in reporting. (Mean Time Between Failure, Mean Time to Repair, Time at Status, etc.).Additionally, a Resource Status code identifies the default “Next” (Production) Transaction for a Resource. This is intended to be a simple implementation of a Resource Status Flow (Resource Workflow).
    ///    @author lichong
    ///    @date 2024/4/22
    [Table("RESOURCESTATUSCODE")]
    public class ResourceStatusCode : UserCode
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("RESOURCESTATUSCODEID")]
        public string? InstanceID { get; set; }

        [Column("RESOURCESTATUSCODENAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<ResourceStatusCode> ResourceStatusCodes { get; set; }
    }
    public class ResourceStatusCodeEntityTypeConfiguration : IEntityTypeConfiguration<ResourceStatusCode>
    {
        public void Configure(EntityTypeBuilder<ResourceStatusCode> builder)
        {

        }
    }
}
