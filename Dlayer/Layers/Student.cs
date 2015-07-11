using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlayer
{
    public class Student : BaseEntity
    {
        public string StudentName { get; set; }
        public IList<StudentCourse> StudentCourses { get; set; }
    }
}
