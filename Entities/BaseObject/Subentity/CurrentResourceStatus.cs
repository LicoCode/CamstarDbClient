using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description There are multiple status’s that can be concurrently tracked for any given Resource. Product Status, Preventative Maintenance (PM), and Logs are examples of pre-defined Resource Status’s. Status categories have many attributes in common; Status Code, Reason Code, History, etc. Resources Status is used as the base definition for all of the specific statuses.
    ///    @author lichong
    ///    @date 2024/4/22
    [NotMapped]
    public abstract class CurrentResourceStatus: Subentity
    {
        public int? CDOTypeId { get; set; }

        public int? ChangeCount { get; set; }

        public string? InstanceID { get; set; }

    }
}


