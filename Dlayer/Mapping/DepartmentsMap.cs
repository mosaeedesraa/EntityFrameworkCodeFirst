using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlayer
{
    public class DepartmentsMap : _EntityTypeConfiguration<Department>
    {
        public DepartmentsMap()
        {
            this.ToTable("Departments");
            this.HasKey(pk => pk.Id);
            this.Property(pb => pb.Name).IsRequired();
            this.Property(pb => pb.Location).IsRequired();

         
        }
    }
}
