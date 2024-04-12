using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description Attributes that are common to all CDOs that include revision control (for instances). There are two CDO Definitions for each; a Base Entity and a Revision Entity.
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class RevisionedObject: BaseObject
    {
        public virtual RevisionBase? Base { get; set; }

        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? Description { get; set; }

        public string? InstanceID { get; set; }

        public string? Notes { get; set; }

        public string? Revision { get; set; }

    }
}


