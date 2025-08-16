using System;
using ResiSecure.Permissions;
using ResiSecure.Property.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ResiSecure.Property;

public class PropertyAppService: 
    CrudAppService<
        Entities.Property,
        PropertyDto, 
        Guid, 
        PagedAndSortedResultRequestDto, 
        CreateUpdatePropertyDto>,
        IPropertyAppService
{
    public PropertyAppService(IRepository<Entities.Property, Guid> repository): base(repository)
    {
        GetPolicyName = ResiSecurePermissions.Properties.Default;
        GetListPolicyName = ResiSecurePermissions.Properties.Default;
        CreatePolicyName = ResiSecurePermissions.Properties.Create;
        UpdatePolicyName = ResiSecurePermissions.Properties.Edit;
        DeletePolicyName = ResiSecurePermissions.Properties.Delete;
        
    }
    
}