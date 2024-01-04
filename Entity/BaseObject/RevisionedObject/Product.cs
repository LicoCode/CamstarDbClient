using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CamstarHelper.Entity
{
    [Table("Product")]
    public class Product : RevisionedObject
    {
        [Key]
        [Column("ProductId")]
        public new string InstanceId { get; set; }
        public virtual ProductBase ProductBase { get; set; }
        [Column("ProductRevision")]
        public new string? Revision { get; set; }
    }
}
