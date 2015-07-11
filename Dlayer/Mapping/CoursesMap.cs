using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlayer
{
    public partial class CoursesMap : _EntityTypeConfiguration<Course>
    {
        public CoursesMap()
        {
            this.ToTable("Cources");
            this.HasKey(a => a.Id);
            this.Property(pb => pb.CourseName).IsRequired();
        }
    }
}
