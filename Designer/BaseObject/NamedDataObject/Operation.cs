//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

///    @Description An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.
///
///The Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. 
///
///
///    @author lichong
///    @date 2024/3/24
///
namespace CamstarClient.Entity {
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CamstarClient.Enum;
    
    [Table("OPERATION")]
    public class Operation : NamedDataObject {
        public virtual WorkCenter WorkCenter {
            get; set;
        }
        public virtual LossReasonGroup LossReasons {
            get; set;
        }
        public virtual ContainerDefectReasonGroup ContainerDefectReasons {
            get; set;
        }
        public virtual ComponentDefectReasonGroup ComponentDefectReasons {
            get; set;
        }
        [Column("OPERATIONNAME")]
        public string Name {
            get; set;
        }
        [Column("DESCRIPTION")]
        public string Description {
            get; set;
        }
        public virtual BuyReasonGroup BuyReasons {
            get; set;
        }
        public virtual QtyAdjustReasonGroup QtyAdjustReasons {
            get; set;
        }
        [Column("USEQUEUE")]
        public System.Nullable<bool> UseQueue {
            get; set;
        }
        public virtual ContainerLevel ThruputReportingLevel {
            get; set;
        }
        public virtual ObjectGroup AutoAdjustReason {
            get; set;
        }
        [Column("AUTOADJUSTLIMIT")]
        public System.Nullable<double> AutoAdjustLimit {
            get; set;
        }
        [Column("CHANGECOUNT")]
        public System.Nullable<int> ChangeCount {
            get; set;
        }
        [Column("OPERATIONID")]
        [Key()]
        public string InstanceID {
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