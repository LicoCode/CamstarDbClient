using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components.
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class BusinessProcessSpec: RevisionedObject
    {
        public virtual BusinessProcessSpecBase? Base { get; set; }

        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? Description { get; set; }

        public string? InstanceID { get; set; }

        public string? Notes { get; set; }

        public string? Revision { get; set; }

    }
}


