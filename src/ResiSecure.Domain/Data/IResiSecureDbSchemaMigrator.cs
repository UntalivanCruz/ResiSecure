using System.Threading.Tasks;

namespace ResiSecure.Data;

public interface IResiSecureDbSchemaMigrator
{
    Task MigrateAsync();
}
