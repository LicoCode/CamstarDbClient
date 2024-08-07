//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

///    @Description A list of reason codes that describe the purpose of a component issue.
///    @author lichong
///    @date 2024/3/24
///
namespace CamstarDb.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using global::CamstarDb.Entities.Enum;

    [Table("ISSUEREASON")]
    public class IssueReason : UserCode {
        [Column("CHANGECOUNT")]
        public System.Nullable<int> ChangeCount {
            get; set;
        }
        [Column("ISSUEREASONID")]
        [Key()]
        public string InstanceID {
            get; set;
        }
        [Column("ISSUEREASONNAME")]
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
