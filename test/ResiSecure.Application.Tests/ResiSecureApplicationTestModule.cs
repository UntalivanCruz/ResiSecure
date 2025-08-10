using Volo.Abp.Modularity;

namespace ResiSecure;

[DependsOn(
    typeof(ResiSecureApplicationModule),
    typeof(ResiSecureDomainTestModule)
)]
public class ResiSecureApplicationTestModule : AbpModule
{

}
