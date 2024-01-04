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
    [Table("LossReasonGroup")]
    public class LossReasonGroup : UserCodeGroup
    {
        public new virtual IEnumerable<LossReason>? Entities { get; set; }
        public new virtual IEnumerable<LossReasonGroup> Groups { get; set; }
        [Column("LossReasonGroupName")]
        public new string Name { get; set; }
        [Key]
        [Column("LossReasonGroupId")]
        public new string InstanceId { get; set; }
    }
}
