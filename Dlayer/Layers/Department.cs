using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlayer
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual IList<Employee> Employees { get; set; }
    }
}
