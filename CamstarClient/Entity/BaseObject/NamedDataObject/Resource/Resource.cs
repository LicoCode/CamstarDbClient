
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamstarHelper.Entity
{
    [Table("ResourceDef")]
    public class Resource : NamedDataObject
    {
        [Key]
        [Column("ResourceId")]
        public new string InstanceId { get; set; }
        [Column("ResourceName")]
        public new string Name { get; set; }
    }
}
