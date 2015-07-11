using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlayer
{
    public partial class EmployeesMap : _EntityTypeConfiguration<Employee>
    {
        public EmployeesMap()
        {
            this.ToTable("Employees");
            this.HasKey(a => a.Id);
            this.Property(pb => pb.FirstName).IsRequired();
            this.Property(pb => pb.LastName).IsRequired();
            this.Property(pb => pb.Salary).IsRequired();
            this.Property(pb => pb.Gender).IsRequired();

            this.HasRequired(t => t.Departments)
             .WithMany(c => c.Employees)
             .HasForeignKey(t => t.DID)
             .WillCascadeOnDelete(false); 
        }
    }
}
