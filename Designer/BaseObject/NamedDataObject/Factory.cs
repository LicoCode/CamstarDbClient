//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

///    @Description A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. 
///    @author lichong
///    @date 2024/3/24
///
namespace CamstarClient.Entity {
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CamstarClient.Enum;
    
    [Table("FACTORY")]
    public class Factory : NamedDataObject {
        public virtual Enterprise Enterprise {
            get; set;
        }
        [Column("FACTORYID")]
        [Key()]
        public string InstanceID {
            get; set;
        }
        [Column("FACTORYNAME")]
        public string Name {
            get; set;
        }
        [Column("DESCRIPTION")]
        public string Description {
            get; set;
        }
        [Column("CHANGECOUNT")]
        public System.Nullable<int> ChangeCount {
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
        public virtual PrintQueue PrintQueue {
            get; set;
        }
    }
}