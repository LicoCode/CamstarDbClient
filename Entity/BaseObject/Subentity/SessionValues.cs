

namespace CamstarClient.Entity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("SESSIONVALUES")]
    public class SessionValues : Subentity
    {
        [Column("SESSIONVALUESID")]
        [Key()]
        public new string InstanceID
        {
            get; set;
        }
    }
}
