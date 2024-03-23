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
    
    [Table("PRODUCTFAMILY")]
    public class ProductFamily : NamedDataObject {
        [Column("PRODUCTFAMILYNAME")]
        public new string Name {
            get; set;
        }
        [Column("DESCRIPTION")]
        public new string Description {
            get; set;
        }
        [Column("CHANGECOUNT")]
        public new System.Nullable<int> ChangeCount {
            get; set;
        }
        [Column("PRODUCTFAMILYID")]
        [Key()]
        public new string InstanceID {
            get; set;
        }
        [Column("CDOTYPEID")]
        public new System.Nullable<int> CDOTypeId {
            get; set;
        }
        [Column("NOTES")]
        public new string Notes {
            get; set;
        }
    }
}
