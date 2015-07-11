using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlayer
{
    public partial class StudentsMap : _EntityTypeConfiguration<Student>
    {
        public StudentsMap()
        {
            this.ToTable("Students");
            this.HasKey(a => a.Id);
            this.Property(pb => pb.StudentName).IsRequired();
        }
    }
}
