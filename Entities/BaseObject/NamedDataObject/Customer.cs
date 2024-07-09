using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDb.Entities;

namespace CamstarDb.Entities
{
    ///    @Description A Customer refers to a company that receives goods and services. A Customer definition typically refers to a company other than your own, but it can also be used for a factory or department that requires goods and services from another factory or department within the enterprise.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("CUSTOMER")]
    public class Customer : NamedDataObject
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("CUSTOMERID")]
        public string? InstanceID { get; set; }

        [Column("CUSTOMERNAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

    }
}

namespace CamstarDb.Context
{
    public partial class CamstarDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
    public class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

        }
    }
}
