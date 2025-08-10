using ResiSecure.Samples;
using Xunit;

namespace ResiSecure.EntityFrameworkCore.Applications;

[Collection(ResiSecureTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ResiSecureEntityFrameworkCoreTestModule>
{

}
