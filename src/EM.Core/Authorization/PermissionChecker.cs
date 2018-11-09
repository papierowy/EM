using Abp.Authorization;
using EM.Authorization.Roles;
using EM.Authorization.Users;

namespace EM.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
