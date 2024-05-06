using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description ERP Routes are the closest ERP concept to an InSite workflow.  The ERPRoute object in InSite is meant to be a mirror of the route definitions in the ERP, where the definition stored in the ERP is the "master" and the InSite ERPRoute is populated via LiveConnect.  The ERPRoute is used to be able to relate InSite Moves and ComponentIssues to the ERPStep where the transaction occurred.  Steps in an ERP route are usually defined at a more summarized level than is true for steps in an InSite workflow.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("ERPROUTE")]
    public class ERPRoute: RevisionedObject
    {
        public virtual ERPRouteBase? Base { get; set; }

        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("ERPROUTEID")]
        public string? InstanceID { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

        [Column("ERPROUTEREVISION")]
        public string? Revision { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<ERPRoute> ERPRoutes { get; set; }
    }
    public class ERPRouteEntityTypeConfiguration : IEntityTypeConfiguration<ERPRoute>
    {
        public void Configure(EntityTypeBuilder<ERPRoute> builder)
        {
            builder.HasOne(e => e.Base).WithMany(e => e.Revisions).HasForeignKey("ERPROUTEBASEID").IsRequired(true);
        }
    }
}
