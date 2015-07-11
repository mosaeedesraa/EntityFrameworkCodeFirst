using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dlayer
{
    /// <summary>
    /// Designed by : End Mohamad Alsaid
    /// </summary>
    public class _DbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public _DbContext()
            : base("server=192.168.1.100;database=Sample;user ID=logo;password=logo;Connection Timeout=6000")
        {
            // Init DB if itsn't created yet 
            Database.SetInitializer<_DbContext>(new CreateDatabaseIfNotExists<_DbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // One to Many
            modelBuilder.Configurations.Add(new EmployeesMap());
            modelBuilder.Configurations.Add(new DepartmentsMap());


            // Many To Many
            modelBuilder.Configurations.Add(new StudentsMap());
            modelBuilder.Configurations.Add(new CoursesMap());


            base.OnModelCreating(modelBuilder);
        }

    }
}
