//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

///    @Description A User Code Object Group that represents a group of Container Defect Reasons.
///    @author lichong
///    @date 2024/3/24
///
namespace CamstarDb.Entities {
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using global::CamstarDb.Entities.Enum;
    
    [Table("CONTDEFECTREASONGROUP")]
    public class ContainerDefectReasonGroup : UserCodeGroup {
        public virtual ICollection<ContainerDefectReasonGroup> Groups {
            get; set;
        }
        public virtual ICollection<ContainerDefectReason> Entries {
            get; set;
        }
        [Column("CHANGECOUNT")]
        public System.Nullable<int> ChangeCount {
            get; set;
        }
        [Column("DEFECTREASONGROUPID")]
        [Key()]
        public string InstanceID {
            get; set;
        }
        [Column("DEFECTREASONGROUPNAME")]
        public string Name {
            get; set;
        }
        [Column("ISFROZEN")]
        public System.Nullable<bool> IsFrozen {
            get; set;
        }
        [Column("ICONID")]
        public System.Nullable<int> IconId {
            get; set;
        }
        [Column("DESCRIPTION")]
        public string Description {
            get; set;
        }
        [Column("ENTRYTYPE")]
        public string EntryType {
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
