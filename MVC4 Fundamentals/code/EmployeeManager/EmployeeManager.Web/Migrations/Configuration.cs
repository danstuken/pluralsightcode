namespace EmployeeManager.Web.Migrations
{
    using System.Data.Entity.Migrations;
    using EmployeeManager.Domain;
    using EmployeeManager.Web.Infrastructure;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeManager.Web.Infrastructure.DepartmentDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EmployeeManager.Web.Infrastructure.DepartmentDb context)
        {
            context.Departments.AddOrUpdate(department => department.Name,
                new Department { Name = "Sales"},
                new Department { Name = "HR" },
                new Department { Name = "Engineering" },
                new Department { Name = "Shipping" });
            MembershipInitialiser.SeedMembership();
        }
    }
}
