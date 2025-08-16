using System;
using System.Threading.Tasks;
using ResiSecure.Entities;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.MultiTenancy;

namespace ResiSecure.Seeders;

public class PropertyStoreDataSeederContributor: IDataSeedContributor, ITransientDependency
{
    private readonly ICurrentTenant _currentTenant;
    private readonly IRepository<Property, Guid> _propertyRepository;
    public PropertyStoreDataSeederContributor(ICurrentTenant currentTenant, IRepository<Property, Guid> propertyRepository)
    {
        _currentTenant = currentTenant;
        _propertyRepository = propertyRepository;
    }
    public async Task SeedAsync(DataSeedContext context)
    {
        using (_currentTenant.Change(context?.TenantId))
        {
            if (await _propertyRepository.GetCountAsync() > 0)
            {
                return;
            }
            var propertyDataFake = new Property
            {
                Code = "PROP001",
                AddressLine = "123 Main St, Springfield",
                BuildingType = Enums.BuildingType.Apartment,
                BuildingArea = 1200.5,
                FloorNumber = 5,
                Color = "#FF5733"
            };
            await _propertyRepository.InsertAsync(propertyDataFake);
        }
    }
}