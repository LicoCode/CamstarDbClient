//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

///    @Description A step in an ERPRoute, which is the closest ERP concept to an InSite workflow.  ERP Route Steps are usually defined at a more summarized level than InSite workflow steps.
///    @author lichong
///    @date 2024/3/24
///
namespace CamstarDbClient.Entities {
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CamstarDbClient.Entities.Enum;
    
    [Table("ROUTESTEP")]
    public class RouteStep : NamedSubentity {
        [Column("ROUTESTEPID")]
        [Key()]
        public string InstanceID {
            get; set;
        }
        [Column("CHANGECOUNT")]
        public System.Nullable<int> ChangeCount {
            get; set;
        }
        [Column("NAME")]
        public string Name {
            get; set;
        }
        [Column("CDOTYPEID")]
        public System.Nullable<int> CDOTypeId {
            get; set;
        }
    }
}
