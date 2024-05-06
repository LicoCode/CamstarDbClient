using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description An ObjectGroup is used to provide a list of objects, such as a list of Resources, Products or User Codes of a particular type. These lists are typically used for validation and selection. For example, an Operation includes a reference to a LossCodeGroup. The entries in this list define the valid Loss (reason) Codes for work performed while a Container is at that Operation.An instance of an ObjectGroup includes a list of specific objects and a list of ObjectGroups. This list of objects for any given ObjectGroup is restricted to a specific type (or any of its derived types). Likewise, the list of ObjectGroup s within the ObjectGroup is restricted to the same type (or any of its derived types).
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class ObjectGroup: NamedDataObject
    {
        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? Description { get; set; }

        public string? InstanceID { get; set; }

        public string? Name { get; set; }

        public string? Notes { get; set; }

    }
}


