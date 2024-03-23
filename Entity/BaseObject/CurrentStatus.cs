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
    
    [Table("CURRENTSTATUS")]
    public class CurrentStatus : BaseObject {
        [Column("CURRENTSTATUSID")]
        [Key()]
        public new string InstanceID {
            get; set;
        }
        public virtual Factory Factory {
            get; set;
        }
        public virtual Resource Resource {
            get; set;
        }
        public virtual SpecStep WorkflowStep {
            get; set;
        }
        [Column("LASTMOVEDATE")]
        public System.Nullable<System.DateTime> LastMoveDate {
            get; set;
        }
        [Column("INPROCESS")]
        public System.Nullable<bool> InProcess {
            get; set;
        }
        [Column("CHANGECOUNT")]
        public new System.Nullable<int> ChangeCount {
            get; set;
        }
        public virtual Spec Spec {
            get; set;
        }
        [Column("INREWORK")]
        public System.Nullable<bool> InRework {
            get; set;
        }
        [Column("CDOTYPEID")]
        public new System.Nullable<int> CDOTypeId {
            get; set;
        }
        [Column("INQUEUETIME")]
        public System.Nullable<double> InQueueTime {
            get; set;
        }
        [Column("ISRESOURCENAME")]
        public string isResourceName {
            get; set;
        }
        [Column("ISWORKFLOWSTEPNAME")]
        public string isWorkflowStepName {
            get; set;
        }
        [Column("ISWORKFLOWNAME")]
        public string isWorkflowName {
            get; set;
        }
        [Column("ISSPECREVISION")]
        public string isSpecRevision {
            get; set;
        }
        [Column("ISWORKFLOWREVISION")]
        public string isWorkflowRevision {
            get; set;
        }
        [Column("ISWORKFLOWSTEPSEQUENCE")]
        public System.Nullable<int> isWorkflowStepSequence {
            get; set;
        }
        [Column("ISSPECNAME")]
        public string isSpecName {
            get; set;
        }
        [Column("ISFACTORYNAME")]
        public string isFactoryName {
            get; set;
        }
        [Column("ISOPERATIONNAME")]
        public string isOperationName {
            get; set;
        }
        [Column("ISOPSTARTQTY")]
        public System.Nullable<double> isOpStartQty {
            get; set;
        }
        [Column("LASTMOVEOUTDATE")]
        public System.Nullable<System.DateTime> LastMoveOutDate {
            get; set;
        }
        [Column("MOVEINDATE")]
        public System.Nullable<System.DateTime> MoveInDate {
            get; set;
        }
    }
}
