//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

///    @Description RevisionedObjectGroup is used to provide a list of revisioned object.
///
///    @author lichong
///    @date 2024/3/24
///
namespace CamstarDb.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CamstarDb.Entities;
    using CamstarDb.Entities;
    using global::CamstarDb.Entities.Enum;

    [NotMapped()]
    public abstract class RevisionedObjectGroup : ObjectGroup {
        public string EntryType {
            get; set;
        }
        public string Name {
            get; set;
        }
        public System.Nullable<int> CDOTypeId {
            get; set;
        }
        public string Notes {
            get; set;
        }
        public virtual ICollection<RevisionedObject> Entries {
            get; set;
        }
        public string InstanceID {
            get; set;
        }
        public System.Nullable<int> ChangeCount {
            get; set;
        }
        public string Description {
            get; set;
        }
        public virtual ICollection<RevisionedObjectGroup> Groups {
            get; set;
        }
       
    }
}
