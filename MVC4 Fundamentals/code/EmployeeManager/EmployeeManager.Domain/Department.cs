namespace EmployeeManager.Domain
{
    using System.Collections.Generic;

    public class Department
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}