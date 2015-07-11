using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlayer
{
   public class Course : BaseEntity
    {
        public string CourseName { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
