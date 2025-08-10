using ResiSecure.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ResiSecure.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ResiSecureEntityFrameworkCoreModule),
    typeof(ResiSecureApplicationContractsModule)
)]
public class ResiSecureDbMigratorModule : AbpModule
{
}
