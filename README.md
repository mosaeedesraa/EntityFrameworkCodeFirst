# Entity Framework Code First

# All relations between tables (one to many && many to many)

# Installation : 

1 -  Web.config : 

<connectionStrings>
    <add name="_DbContext" 
         connectionString="server=.;database=Sample;user ID=sa;password=sa;Connection Timeout=6000" providerName="System.Data.SqlClient" />
  </connectionStrings>
  
2 - In _DbContext : 

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
  
  3 - This is example for table map : 
  
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
    
    
