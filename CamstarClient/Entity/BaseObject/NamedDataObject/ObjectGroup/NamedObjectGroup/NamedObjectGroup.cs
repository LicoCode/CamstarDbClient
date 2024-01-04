using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamstarHelper.Entity
{
    [Table("NamedObjectGroup")]
    public class NamedObjectGroup : NamedDataObject
    {
        public virtual IEnumerable<NamedDataObject>? Entities { get; set; }
        public string EntryType { get; set; }
        public virtual IEnumerable<NamedObjectGroup> Groups { get; set; }
        [Column("NamedObjectGroupName")]
        public new string Name { get; set; }
        [Key]
        [Column("NamedObjectGroupId")]
        public new string InstanceId { get; set; }
    }
}
