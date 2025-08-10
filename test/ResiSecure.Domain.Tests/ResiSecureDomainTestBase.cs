using Volo.Abp.Modularity;

namespace ResiSecure;

/* Inherit from this class for your domain layer tests. */
public abstract class ResiSecureDomainTestBase<TStartupModule> : ResiSecureTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
