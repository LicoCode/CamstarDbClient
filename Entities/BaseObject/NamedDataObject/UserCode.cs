using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description User codes are most often used to define loss reasons through selection lists for data entry fields. InSite provides several user codes such as Bonus Reason and Loss Reason. User Defined Codes are used to allow each customer to specify a list of allowable values for a specific field. In many cases a User Defined Code will merely consist of a Name and Description with no additional attributes. They may also include additional attributes, typically used for additional validations.The name for each Code must be unique within its type. This value is used as an alternate key for lookup-up, data entry and validation.
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class UserCode: NamedDataObject
    {
        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? Description { get; set; }

        public string? InstanceID { get; set; }

        public string? Name { get; set; }

        public string? Notes { get; set; }

    }
}


