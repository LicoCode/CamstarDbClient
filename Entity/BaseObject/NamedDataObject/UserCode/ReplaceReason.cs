//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
//    @author lichong
//    @date 2024/3/23
//
namespace CamstarClient.Entity {
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    [Table("REPLACEREASON")]
    public class ReplaceReason : UserCode {
        [Column("CDOTYPEID")]
        public new System.Nullable<int> CDOTypeId {
            get; set;
        }
        [Column("REPLACEREASONID")]
        [Key()]
        public new string InstanceID {
            get; set;
        }
        [Column("CHANGECOUNT")]
        public new System.Nullable<int> ChangeCount {
            get; set;
        }
        [Column("NOTES")]
        public new string Notes {
            get; set;
        }
        [Column("DESCRIPTION")]
        public new string Description {
            get; set;
        }
        [Column("REPLACEREASONNAME")]
        public new string Name {
            get; set;
        }
        [Column("ISSCRAPREMOVED")]
        public System.Nullable<bool> IsScrapRemoved {
            get; set;
        }
    }
}
