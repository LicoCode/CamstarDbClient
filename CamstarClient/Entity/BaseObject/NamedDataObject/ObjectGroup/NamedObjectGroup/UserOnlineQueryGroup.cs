using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamstarHelper.Entity;

namespace CamstarHelper.Entity
{
    [Table("NamedObjectGroup")]
    public class UserOnlineQueryGroup : NamedObjectGroup
    {
        public new virtual IEnumerable<UserOnlineQuery>? Entities { get; set; }
        public string? EntryType { get; set; }
        public new virtual IEnumerable<UserOnlineQueryGroup> Groups { get; set; }
        [Column("NamedObjectGroupName")]
        public new string Name { get; set; }
        [Key]
        [Column("NamedObjectGroupId")]
        public new string InstanceId { get; set; }
    }
}
