using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CamstarDb.Entities
{
    ///    @Description Named Subentity
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class NamedSubentity : Subentity
    {
        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? InstanceID { get; set; }

        public string? Name { get; set; }

    }
}


