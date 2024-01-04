
using System.ComponentModel.DataAnnotations.Schema;

namespace CamstarHelper.Entity
{
    [NotMapped]
    public class NamedDataObject : BaseObject
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Notes { get; set; }
    }
}
