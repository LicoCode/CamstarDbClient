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
    [Table("LossReason")]
    public class LossReason : UserCode
    {
        [Column("LossReasonName")]
        public new string Name { get; set; }
        [Key]
        [Column("LossReasonId")]
        public new string InstanceId { get; set; }
    }
}
