using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description TrainingRequirement Group
    ///    @author lichong
    ///    @date 2024/5/20
    [Table("TRAININGREQUIREMENTGROUP")]
    public class TrainingReqGroup : RevisionedObjectGroup
    {
        public virtual ICollection<TrainingReqGroup>? TrainingReqGroups { get; set; }

        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("TRAININGREQUIREMENTGROUPNAME")]
        public string? Name { get; set; }


        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        public virtual ICollection<TrainingRequirement>? Entries { get; set; }

        public virtual ICollection<TrainingReqGroup>? Groups { get; set; }

        [Key]
        [Column("TRAININGREQUIREMENTGROUPID")]
        public string? InstanceID { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }
        [Column("ENTRYTYPE")]
        public string EntryType
        {
            get; set;
        }

        public List<TrainingRequirement> GetEnties()
        {
            var reworkReasons = new List<TrainingRequirement>();
            reworkReasons.AddRange(Entries);
            if (Groups != null)
            {
                foreach (var group in Groups)
                {
                    reworkReasons.AddRange(group.GetEnties());
                }
            }
            return reworkReasons;
        }

    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<TrainingReqGroup> TrainingReqGroups { get; set; }
    }
    public class TrainingReqGroupEntityTypeConfiguration : IEntityTypeConfiguration<TrainingReqGroup>
    {
        public void Configure(EntityTypeBuilder<TrainingReqGroup> builder)
        {
            builder
.HasMany(e => e.Entries)
.WithMany(e => e.TrainingReqGroups)
.UsingEntity<Dictionary<string, object>>(
"TRAININGREQGROUPENTRIES",
l => l.HasOne<TrainingRequirement>().WithMany().HasForeignKey("ENTRIESID"),
r => r.HasOne<TrainingReqGroup>().WithMany().HasForeignKey("TRAININGREQUIREMENTGROUPID"),
j =>
{
    j.HasKey("TRAININGREQUIREMENTGROUPID", "ENTRIESID");

}
);
            builder
        .HasMany(e => e.Groups)
        .WithMany(e => e.TrainingReqGroups)
        .UsingEntity<Dictionary<string, object>>(
            "TRAININGREQGROUPGROUPS",
            l => l.HasOne<TrainingReqGroup>().WithMany().HasForeignKey("GROUPSID"),
            r => r.HasOne<TrainingReqGroup>().WithMany().HasForeignKey("TRAININGREQUIREMENTGROUPID"),
            j =>
            {
                j.HasKey("TRAININGREQUIREMENTGROUPID", "GROUPSID");

            }
        );

        }
    }
}
