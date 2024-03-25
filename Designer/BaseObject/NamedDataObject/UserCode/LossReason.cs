//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

///    @Description The user code for loss reason.
///    @author lichong
///    @date 2024/3/24
///
namespace CamstarClient.Entity {
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CamstarClient.Enum;
    
    [Table("LOSSREASON")]
    public class LossReason : UserCode {
        [Column("DESCRIPTION")]
        public string Description {
            get; set;
        }
        [Column("LOSSREASONNAME")]
        public string Name {
            get; set;
        }
        [Column("CHANGECOUNT")]
        public System.Nullable<int> ChangeCount {
            get; set;
        }
        [Column("LOSSREASONID")]
        [Key()]
        public string InstanceID {
            get; set;
        }
        [Column("CDOTYPEID")]
        public System.Nullable<int> CDOTypeId {
            get; set;
        }
        [Column("NOTES")]
        public string Notes {
            get; set;
        }
    }
}