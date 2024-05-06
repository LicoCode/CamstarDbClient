//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

///    @Description A User Code Object Group that represents a group of Component Defect Reasons.
///    @author lichong
///    @date 2024/3/24
///
namespace CamstarDbClient.Entities {
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CamstarDbClient.Entities.Enum;
    
    [Table("COMPDEFECTREASONGROUP")]
    public class ComponentDefectReasonGroup : UserCodeGroup {
        [Column("CHANGECOUNT")]
        public System.Nullable<int> ChangeCount {
            get; set;
        }
        [Column("COMPDEFECTREASONGROUPID")]
        [Key()]
        public string InstanceID {
            get; set;
        }
        [Column("DESCRIPTION")]
        public string Description {
            get; set;
        }
        [Column("COMPDEFECTREASONGROUPNAME")]
        public string Name {
            get; set;
        }
        [Column("ENTRYTYPE")]
        public string EntryType {
            get; set;
        }
        public virtual ICollection<ComponentDefectReason> Entries {
            get; set;
        }
        public virtual ICollection<ComponentDefectReasonGroup> Groups {
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
