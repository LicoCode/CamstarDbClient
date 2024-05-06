using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    [Table("T_ECNCONFIRMATIONDETAIL")]
    public class T_ECNConfirmationDetail : NamedSubentity
    {
        [Key]
        [Column("T_ECNCONFIRMATIONDETAILID")]
        public string? InstanceID { get; set; }

        [Column("T_ECNCONFIRMATIONDETAILNAME")]
        public string? Name { get; set; }

        [ForeignKey("MFGORDERID")]
        public virtual MfgOrder? Parent { get; set; }

        [Column("CHANGECOUNT")]
        public string? ChangeCount { get; set; }

        [Column("CDOTYPEID")]
        public string? CDOTypeId { get; set; }

        [Column("T_ECNTYPEID")]
        public bool? T_ECNType { get; set; }

        [Column("CONTENT")]
        public string? Content { get; set; }

        [ForeignKey("CONFIRMERID")]
        public virtual Employee? Confirmer { get; set; }

        [Column("CONFIRMEDTIME")]
        public DateTime? ConfirmedTime { get; set; }
    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<T_ECNConfirmationDetail> T_ECNConfirmationDetails { get; set; }
    }
    public class T_ECNConfirmationDetailEntityTypeConfiguration : IEntityTypeConfiguration<T_ECNConfirmationDetail>
    {
        public void Configure(EntityTypeBuilder<T_ECNConfirmationDetail> builder)
        {

        }
    }
}