using System;
using ResiSecure.Property.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ResiSecure.Property;

public interface IPropertyAppService: 
    ICrudAppService<
        PropertyDto, 
        Guid, 
        PagedAndSortedResultRequestDto, 
        CreateUpdatePropertyDto>
{
    
}