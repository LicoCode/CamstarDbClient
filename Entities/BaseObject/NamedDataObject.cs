using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CamstarDb.Entities
{
    ///    @Description Factory modeling objects that can be uniquely identified by name.
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class NamedDataObject : BaseObject
    {
        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? Description { get; set; }

        public string? InstanceID { get; set; }

        public string? Name { get; set; }

        public string? Notes { get; set; }

    }
}


