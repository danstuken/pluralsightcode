namespace EmployeeManager.Domain
{
    using System;
    using System.Linq;

    public interface DepartmentDataSource
    {
        IQueryable<Employee> Employees { get; }
        IQueryable<Department> Departments { get; }
        IQueryable<UserProfile> UserProfiles { get; }
        void Save();
    }
}