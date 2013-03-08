namespace EmployeeManager.Domain
{
    using System;

    public class Employee
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime? HireDate { get; set; }
    }
}