using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CamstarDbClient.Entities;

namespace CamstarDbClient.Entities
{
    ///    @Description An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.The Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.
    ///    @author lichong
    ///    @date 2024/4/12
    [Table("EMPLOYEE")]
    public class Employee: NamedDataObject
    {
        [Column("CDOTYPEID")]
        public int? CDOTypeId { get; set; }

        [Column("CHANGECOUNT")]
        public int? ChangeCount { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Key]
        [Column("EMPLOYEEID")]
        public string? InstanceID { get; set; }

        [Column("EMPLOYEENAME")]
        public string? Name { get; set; }

        [Column("NOTES")]
        public string? Notes { get; set; }

        [ForeignKey("SESSIONVALUESID")]
        public virtual SessionValues? SessionValues { get; set; }

    }
}

namespace CamstarDbClient.CamstarContext
{
    public partial class CamstarDbContext : DbContext {
        public DbSet<Employee> Employees { get; set; }
    }
    public class EmployeeEntityTypeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            
        }
    }
}
