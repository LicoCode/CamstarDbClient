using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CamstarHelper.Entity
{
    [Table("ProductBase")]
    public class ProductBase : RevisionBase
    {
        public virtual IEnumerable<Product> Revisions { get; set; }
        public virtual Product RevOfRcd { get; set; }
        [Key]
        [Column("ProductBaseId")]
        public new string InstanceId { get; set; }
        [Column("ProductName")]
        public new string Name { get; set; }
    }
}
