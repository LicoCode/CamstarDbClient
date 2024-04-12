using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description Stores the components loaded into the Resource. The ResourceComponentSetup must be used to add and remove the components for the Resource. During ComponentIssue, the information here will be used to provide the issue details if a Resource is provided.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("A_RESOURCECOMPONENTS")]
    public class ResourceComponents: ES_Subentities
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Key]
        [Column("RESOURCECOMPONENTSID")]
        public string? InstanceID { get; set; }

        [Column("ISSUECONTROL")]
        public int? IssueControl { get; set; }

        [ForeignKey("ISSUEDIFFERENCEREASONID")]
        public virtual IssueDifferenceReason? IssueDifferenceReason { get; set; }

        [ForeignKey("RESOURCEID")]
        public virtual Resource? Parent { get; set; }

        [ForeignKey("PRODUCTID")]
        public virtual Product? Product { get; set; }
        [ForeignKey("FROMCONTAINERID")]
        public virtual Container? FromContainer { get; set; }
    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<ResourceComponents> ResourceComponentss { get; set; }
    }
    public class ResourceComponentsEntityTypeConfiguration : IEntityTypeConfiguration<ResourceComponents>
    {
        public void Configure(EntityTypeBuilder<ResourceComponents> builder)
        {
            
        }
    }
}
