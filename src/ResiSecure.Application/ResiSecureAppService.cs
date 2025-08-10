using ResiSecure.Localization;
using Volo.Abp.Application.Services;

namespace ResiSecure;

/* Inherit your application services from this class.
 */
public abstract class ResiSecureAppService : ApplicationService
{
    protected ResiSecureAppService()
    {
        LocalizationResource = typeof(ResiSecureResource);
    }
}
