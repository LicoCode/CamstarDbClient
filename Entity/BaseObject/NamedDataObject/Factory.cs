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
    
    [Table("FACTORY")]
    public class Factory : NamedDataObject {
        public virtual Enterprise Enterprise {
            get; set;
        }
        [Column("FACTORYID")]
        [Key()]
        public new string InstanceID {
            get; set;
        }
        public virtual PrintQueue PrintQueue {
            get; set;
        }
    }
}
