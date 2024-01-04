using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamstarHelper.Entity;

[Table("UserCodeGroup")]
public class UserCodeGroup : NamedObjectGroup
{
    public new virtual IEnumerable<UserCode>? Entities { get; set; }
    public string EntryType { get; set; }
    public new virtual IEnumerable<UserCodeGroup> Groups { get; set; }
    [Column("UserCodeGroupName")]
    public new string Name { get; set; }
    [Key]
    [Column("UserCodeGroupId")]
    public new string InstanceId { get; set; }
}
