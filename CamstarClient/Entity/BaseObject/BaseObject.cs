
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CamstarHelper.Entity
{
    [NotMapped]
    public class BaseObject
    {
        public int CDOTypeId { get; set; }
        public int ChangeCount { get; set; }
        public string InstanceId { get; set; }
    }
}
