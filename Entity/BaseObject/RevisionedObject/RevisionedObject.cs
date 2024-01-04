using System.ComponentModel.DataAnnotations.Schema;

namespace CamstarHelper.Entity
{
    [NotMapped]
    public class RevisionedObject : BaseObject
    {
        public string? Description { get; set; }

        public string? Notes { get; set; }

        public string Revision { get; set; }
    }
}
