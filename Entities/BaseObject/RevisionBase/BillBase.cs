using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description A Bill is  an enumerated, well defined list of raw materials, sub-assemblies, instructions, etc. 
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class BillBase: RevisionBase
    {
        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? InstanceID { get; set; }

        public string? Name { get; set; }

    }
}


