using ResiSecure.Samples;
using Xunit;

namespace ResiSecure.EntityFrameworkCore.Domains;

[Collection(ResiSecureTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ResiSecureEntityFrameworkCoreTestModule>
{

}
