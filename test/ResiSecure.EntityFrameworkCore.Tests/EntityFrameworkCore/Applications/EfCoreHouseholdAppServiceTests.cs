using Xunit;

namespace ResiSecure.EntityFrameworkCore.Applications;

[Collection(ResiSecureTestConsts.CollectionDefinitionName)]
public class EfCoreHouseholdAppServiceTests: HouseholdAppService_Tests<ResiSecureEntityFrameworkCoreTestModule>
{
    
}