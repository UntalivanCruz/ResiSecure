using Xunit;

namespace ResiSecure.EntityFrameworkCore.Applications;

[Collection(ResiSecureTestConsts.CollectionDefinitionName)]
public class EfCorePropertyAppServiceTests: PropertyAppService_Tests<ResiSecureEntityFrameworkCoreTestModule>
{
    
}