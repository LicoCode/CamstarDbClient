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
    
    [Table("COMPONENTDEFECTREASON")]
    public class ComponentDefectReason : UserCode {
        [Column("COMPONENTDEFECTREASONID")]
        [Key()]
        public new string InstanceID {
            get; set;
        }
    }
}
