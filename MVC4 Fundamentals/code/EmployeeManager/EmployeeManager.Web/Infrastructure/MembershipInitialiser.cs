namespace EmployeeManager.Web.Infrastructure
{
    using System.Linq;
    using System.Web.Security;
    using WebMatrix.WebData;

    public static class MembershipInitialiser
    {
        public static void SeedMembership()
        {
            WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId", "UserName", autoCreateTables: true);
            var roles = (SimpleRoleProvider) Roles.Provider;
            var membership = (SimpleMembershipProvider) Membership.Provider;

            if (!roles.RoleExists("Admin"))
            {
                roles.CreateRole("Admin");
            }

            if(membership.GetUser("admin",false) ==  null)
            {
                membership.CreateUserAndAccount("admin", "admin");
            }

            if (!roles.GetRolesForUser("admin").Contains("Admin"))
            {
                roles.AddUsersToRoles(new[] {"admin"}, new[] {"Admin"});
            }
        }
    }
}