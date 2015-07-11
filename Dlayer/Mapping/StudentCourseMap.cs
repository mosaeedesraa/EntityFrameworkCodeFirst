using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlayer
{
    public partial class StudentCourseMap : _EntityTypeConfiguration<Student>
    {
        public StudentCourseMap()
        {
            this.ToTable("StudentCourses");
            this.HasKey(a => a.Id);
        }
    }
}
