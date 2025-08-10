using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ResiSecure.Data;
using Volo.Abp.DependencyInjection;

namespace ResiSecure.EntityFrameworkCore;

public class EntityFrameworkCoreResiSecureDbSchemaMigrator
    : IResiSecureDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreResiSecureDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ResiSecureDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ResiSecureDbContext>()
            .Database
            .MigrateAsync();
    }
}
