using Volo.Abp.Modularity;

namespace ResiSecure;

public abstract class ResiSecureApplicationTestBase<TStartupModule> : ResiSecureTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
