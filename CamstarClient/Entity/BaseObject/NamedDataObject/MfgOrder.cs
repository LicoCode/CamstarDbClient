
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CamstarHelper.Entity
{
    /// <summary>
    /// MfgOrder
    /// </summary>
    [Table("MfgOrder")]
    public class MfgOrder : NamedDataObject
    {
        [Key]
        [Column("MfgOrderId")]
        public new string InstanceId { get; set; }
        [Column("MfgOrderName")]
        public new string Name { get; set; }
        public virtual Product? Product { get; set; }
        public virtual ProductBase? ProductBase { get; set; }

    }
}
