using Xunit;

namespace ResiSecure.EntityFrameworkCore;

[CollectionDefinition(ResiSecureTestConsts.CollectionDefinitionName)]
public class ResiSecureEntityFrameworkCoreCollection : ICollectionFixture<ResiSecureEntityFrameworkCoreFixture>
{

}
