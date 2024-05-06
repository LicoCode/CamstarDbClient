using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.A Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.
    ///    @author lichong
    ///    @date 2024/4/12
    [NotMapped]
    public abstract class Step: NamedSubentity
    {
        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? Description { get; set; }

        public string? InstanceID { get; set; }

        public string? Name { get; set; }

        public string? Notes { get; set; }

    }
}


