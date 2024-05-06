using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description ERP Routes are the closest ERP concept to an InSite workflow.  The ERPRoute object in InSite is meant to be a miiror of the route definitions in the ERP, where the definition stored in the ERP is the "master" and the InSite ERPRoute is populated via LiveConnect.  The ERPRoute is used to be able to relate InSite Moves and ComponentIssues to the ERPStep where the transaction occurred.  Steps in an ERP route are usually defined at a more summarized level than is true for steps in an InSite workflow.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("ERPROUTEBASE")]
    public class ERPRouteBase: RevisionBase
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Key]
        [Column("ERPROUTEBASEID")]
        public string? InstanceID { get; set; }

        [Column("ERPROUTENAME")]
        public string? Name { get; set; }
        public virtual ERPRoute? RevOfRcd { get; set; }
        public virtual ICollection<ERPRoute>? Revisions { get; set; }
    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<ERPRouteBase> ERPRouteBases { get; set; }
    }
    public class ERPRouteBaseEntityTypeConfiguration : IEntityTypeConfiguration<ERPRouteBase>
    {
        public void Configure(EntityTypeBuilder<ERPRouteBase> builder)
        {
            builder.HasOne(e => e.RevOfRcd).WithOne().HasForeignKey<ERPRouteBase>("REVOFRCDID").IsRequired(true);
        }
    }
}
