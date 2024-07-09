using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CamstarDb.Entities
{
    ///    @Description Sub-Entities are structures that only exist within the context of another CDO. This typically equates to a list-type field within a Modeling CDO.
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class Subentity : BaseObject
    {
        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? InstanceID { get; set; }

    }
}


