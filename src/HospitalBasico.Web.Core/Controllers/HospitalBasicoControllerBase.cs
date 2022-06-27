using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HospitalBasico.Controllers
{
    public abstract class HospitalBasicoControllerBase: AbpController
    {
        protected HospitalBasicoControllerBase()
        {
            LocalizationSourceName = HospitalBasicoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
