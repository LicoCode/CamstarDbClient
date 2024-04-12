using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.CamstarEntities;

namespace CamstarDbClient.CamstarEntities
{
    ///    @Description The idea behind a Bill is that manufactured products are built using  an enumerated, and well defined list of raw materials and sub-assemblies. These are called Material Lists. A Bill CDO allows a collection of Material Lists to be created.
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class Bill: RevisionedObject
    {
        public virtual BillBase? Base { get; set; }

        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? Description { get; set; }

        public string? InstanceID { get; set; }

        public string? Notes { get; set; }

        public string? Revision { get; set; }

    }
}


