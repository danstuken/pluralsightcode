namespace EmployeeManager.Web.Infrastructure
{
    using System.Data.Entity;
    using System.Linq;
    using EmployeeManager.Domain;

    public class DepartmentDb: DbContext, DepartmentDataSource
    {
        public DepartmentDb(): base("DefaultConnection")
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        
        void DepartmentDataSource.Save()
        {
            SaveChanges();
        }

        IQueryable<Employee> DepartmentDataSource.Employees
        {
            get { return Employees; }
        }

        IQueryable<Department> DepartmentDataSource.Departments
        {
            get { return Departments; }
        }

        IQueryable<UserProfile> DepartmentDataSource.UserProfiles
        {
            get { return UserProfiles; }
        }
    }
}