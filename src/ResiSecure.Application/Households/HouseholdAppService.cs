using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using ResiSecure.Households.Dtos;
using ResiSecure.Entities;
using ResiSecure.Permissions;

namespace ResiSecure.Households
{
    public class HouseholdAppService :
        CrudAppService<
            Household, 
            HouseholdDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateHouseholdDto>,
        IHouseholdAppService
    {
        public HouseholdAppService(IRepository<Household, Guid> repository)
            : base(repository)
        {
            GetPolicyName = ResiSecurePermissions.Households.Default;
            GetListPolicyName = ResiSecurePermissions.Households.Default;
            CreatePolicyName = ResiSecurePermissions.Households.Create;
            UpdatePolicyName = ResiSecurePermissions.Households.Edit;
            DeletePolicyName = ResiSecurePermissions.Households.Delete;
        }
    }
}
