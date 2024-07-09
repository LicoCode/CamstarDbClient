using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description Superclass to contain all additional NDO objects.
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public class ES_NDOs : NamedDataObject
    {
        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? Description { get; set; }

        public string? InstanceID { get; set; }

        public string? Name { get; set; }

        public string? Notes { get; set; }

    }
}


