using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace EM.Controllers
{
    public abstract class EMControllerBase: AbpController
    {
        protected EMControllerBase()
        {
            LocalizationSourceName = EMConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
