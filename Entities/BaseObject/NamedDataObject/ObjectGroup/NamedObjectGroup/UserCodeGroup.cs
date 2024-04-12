//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

///    @Description UserCodeGroup represents a group of user code.
///    @author lichong
///    @date 2024/3/24
///
namespace CamstarDbClient.CamstarEntities {
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CamstarDbClient.CamstarEntities.Enum;
    
    [Table("USERCODEGROUP")]
    public class UserCodeGroup : NamedObjectGroup {
        [Column("CHANGECOUNT")]
        public System.Nullable<int> ChangeCount {
            get; set;
        }
        [Column("USERCODEGROUPID")]
        [Key()]
        public string InstanceID {
            get; set;
        }
        [Column("USERCODEGROUPNAME")]
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
        public virtual ICollection<UserCode> Entries {
            get; set;
        }
        [Column("ENTRYTYPE")]
        public string EntryType {
            get; set;
        }
        public virtual ICollection<UserCodeGroup> Groups {
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