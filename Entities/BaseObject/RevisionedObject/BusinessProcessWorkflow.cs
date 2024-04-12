using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description A Workflow defines the route and processing required for a process, A Workflow is a collection of Steps that are linked by Paths, Steps reference either other Workflows or Specs
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class BusinessProcessWorkflow: RevisionedObject
    {
        public virtual BusinessProcessWorkflowBase? Base { get; set; }

        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? Description { get; set; }

        public string? InstanceID { get; set; }

        public string? Notes { get; set; }

        public string? Revision { get; set; }

    }
}


