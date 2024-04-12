//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

///    @Description Typically applies to manufacturing companies that have areas staffed for a long enough during a day that workers do not all start and end their day at the same time.  Shift is a mechanism for grouping production information based on management responsibilities for workers that start and leave at a particular time.  For example, the "Day" shift might work from 6am to 6pm, and the "Night" shift would work from 6pm to 6am. 
///    @author lichong
///    @date 2024/3/24
///
namespace CamstarDbClient.CamstarEntities {
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CamstarDbClient.CamstarEntities.Enum;
    
    [Table("SHIFT")]
    public class Shift : NamedDataObject {
        [Column("CDOTYPEID")]
        public System.Nullable<int> CDOTypeId {
            get; set;
        }
        [Column("SHIFTID")]
        [Key()]
        public string InstanceID {
            get; set;
        }
        [Column("CHANGECOUNT")]
        public System.Nullable<int> ChangeCount {
            get; set;
        }
        [Column("DESCRIPTION")]
        public string Description {
            get; set;
        }
        [Column("SHIFTNAME")]
        public string Name {
            get; set;
        }
        [Column("NOTES")]
        public string Notes {
            get; set;
        }
    }
}