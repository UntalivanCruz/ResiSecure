using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using ResiSecure.Households.Dtos;

namespace ResiSecure.Households
{
    public interface IHouseholdAppService :
        ICrudAppService<
            HouseholdDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateHouseholdDto>
    {
    }
}
