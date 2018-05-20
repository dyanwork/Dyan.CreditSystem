using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Dyan.OceanAngular.Controllers
{
    public abstract class OceanAngularControllerBase: AbpController
    {
        protected OceanAngularControllerBase()
        {
            LocalizationSourceName = OceanAngularConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
