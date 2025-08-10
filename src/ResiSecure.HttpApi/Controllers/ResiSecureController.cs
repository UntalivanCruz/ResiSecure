using ResiSecure.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ResiSecure.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ResiSecureController : AbpControllerBase
{
    protected ResiSecureController()
    {
        LocalizationResource = typeof(ResiSecureResource);
    }
}
