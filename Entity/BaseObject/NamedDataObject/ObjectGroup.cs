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
//    @date 2024/3/22
//
namespace CamstarClient.Entity {
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public abstract class ObjectGroup : NamedDataObject {
        public string EntryType {
            get; set;
        }
        public virtual ICollection<BaseObject> Entries {
            get; set;
        }
        public virtual ICollection<ObjectGroup> Groups {
            get; set;
        }
        public new string InstanceID {
            get; set;
        }
    }
}
