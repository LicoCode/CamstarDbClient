using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CamstarDb.Entities
{
    ///    @Description A Workflow defines the route and processing required for a process, A Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class BusinessProcessWorkflowBase : RevisionBase
    {
        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? InstanceID { get; set; }

        public string? Name { get; set; }

    }
}


