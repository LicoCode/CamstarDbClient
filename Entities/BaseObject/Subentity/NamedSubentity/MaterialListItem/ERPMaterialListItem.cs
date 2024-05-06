using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description Represents a particular material that is required to complete a given manufacturing or assembly step, as defined by the ERP RouteStep refenced in the current WorkflowStep of the container.  The necessary quantities or proportions of the item are specified as are the appropriate units of measure.
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class ERPMaterialListItem: MaterialListItem
    {
        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? InstanceID { get; set; }

        public string? Name { get; set; }

    }
}


