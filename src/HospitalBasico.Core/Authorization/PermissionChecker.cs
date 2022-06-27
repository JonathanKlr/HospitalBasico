using Abp.Authorization;
using HospitalBasico.Authorization.Roles;
using HospitalBasico.Authorization.Users;

namespace HospitalBasico.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
