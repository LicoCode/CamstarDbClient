using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class MaterialListItem: NamedSubentity
    {
        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? InstanceID { get; set; }

        public string? Name { get; set; }

    }
}


