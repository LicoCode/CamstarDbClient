using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description RevisionBase refers to attributes that are common to all CDOs that include revision control (for instances). There are two CDO Definitions for each; a Base Entity and a Revision Entity.  The RevisionBase holds information common to all revisions of an object, plus information on which revision is the revision of record.
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class RevisionBase: BaseObject
    {
        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? InstanceID { get; set; }

        public string? Name { get; set; }

    }
}


