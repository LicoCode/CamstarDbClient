using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamstarHelper.Entity
{
    [Table("UserQuery")]
    public class UserQuery : NamedDataObject
    {
        public bool? AllowOnlineQuery { get; set; }
        [Column("UserQueryName")]
        public new string Name { get; set; }
        [Key]
        [Column("UserQueryId")]
        public new string InstanceId { get; set; }
        public string? NameColumn { get; set; }
        public string? QueryText { get; set; }
        public int? QueryTypeID { get; set; }
        public int? ResultsetSizeLimit { get; set; }
        public int? UserQueryType { get; set; }
    }
}
