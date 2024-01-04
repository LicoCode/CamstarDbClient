using System.ComponentModel.DataAnnotations.Schema;

namespace CamstarHelper.Entity
{
    [NotMapped]
    public class RevisionBase : BaseObject
    {
        public virtual RevisionedObject RevOfRcd { get; set; }

        public string Name { get; set; }
    }
}
