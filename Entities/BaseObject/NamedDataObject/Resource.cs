using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.A Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("RESOURCEDEF")]
    public class Resource: NamedDataObject
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [ForeignKey("FACTORYID")]
        public virtual Factory? Factory { get; set; }

        [Key]
        [Column("RESOURCEID")]
        public string? InstanceID { get; set; }

        [Column("RESOURCENAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

        [ForeignKey("PARENTRESOURCEID")]
        public virtual Resource? ParentResource { get; set; }

        [ForeignKey("PRINTQUEUEID")]
        public virtual PrintQueue? PrintQueue { get; set; }

        [ForeignKey("RESOURCEFAMILYID")]
        public virtual ResourceFamily? ResourceFamily { get; set; }

        [ForeignKey("RESOURCETYPEID")]
        public virtual ResourceType? ResourceType { get; set; }
        public virtual ICollection<ResourceComponents>? Components { get; set; }
        public virtual ICollection<ResourceGroup> ResourceGroups { get; set; }
    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<Resource> Resources { get; set; }
    }
    public class ResourceEntityTypeConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.HasOne(e => e.ParentResource).WithMany().HasForeignKey("PARENTRESOURCEID").HasPrincipalKey(c => c.InstanceID).IsRequired(false);
        }
    }
}
