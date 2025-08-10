using Microsoft.Extensions.Localization;
using ResiSecure.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ResiSecure;

[Dependency(ReplaceServices = true)]
public class ResiSecureBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<ResiSecureResource> _localizer;

    public ResiSecureBrandingProvider(IStringLocalizer<ResiSecureResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
