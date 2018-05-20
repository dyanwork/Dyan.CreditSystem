using Abp.Authorization;
using Dyan.OceanAngular.Authorization.Roles;
using Dyan.OceanAngular.Authorization.Users;

namespace Dyan.OceanAngular.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
