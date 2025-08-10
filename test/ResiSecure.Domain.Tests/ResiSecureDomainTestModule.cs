using Volo.Abp.Modularity;

namespace ResiSecure;

[DependsOn(
    typeof(ResiSecureDomainModule),
    typeof(ResiSecureTestBaseModule)
)]
public class ResiSecureDomainTestModule : AbpModule
{

}
