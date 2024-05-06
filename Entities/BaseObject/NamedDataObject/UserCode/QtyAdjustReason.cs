//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

///    @Description The user code for qty adjust reason.
///    @author lichong
///    @date 2024/3/24
///
namespace CamstarDbClient.Entities {
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CamstarDbClient.Entities.Enum;
    
    [Table("QTYADJUSTREASON")]
    public class QtyAdjustReason : UserCode {
        [Column("DESCRIPTION")]
        public string Description {
            get; set;
        }
        [Column("QTYADJUSTREASONNAME")]
        public string Name {
            get; set;
        }
        [Column("CHANGECOUNT")]
        public System.Nullable<int> ChangeCount {
            get; set;
        }
        [Column("QTYADJUSTREASONID")]
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
