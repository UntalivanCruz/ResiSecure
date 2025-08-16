using System;
using System.Threading.Tasks;
using ResiSecure.Entities;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.MultiTenancy;

namespace ResiSecure.Seeders;

public class HouseholdStoreDataSeederContributor: IDataSeedContributor, ITransientDependency
{
    private readonly ICurrentTenant _currentTenant;
    private readonly IRepository<Household, Guid> _householdRepository;
    private readonly IRepository<Property, Guid> _propertyRepository;
    
    public HouseholdStoreDataSeederContributor(
        ICurrentTenant currentTenant, 
        IRepository<Household, Guid> householdRepository,
        IRepository<Property, Guid> propertyRepository)
    {
        _currentTenant = currentTenant;
        _householdRepository = householdRepository;
        _propertyRepository = propertyRepository;
    }
    public async Task SeedAsync(DataSeedContext context)
    {
        using (_currentTenant.Change(context?.TenantId))
        {
            if (await _householdRepository.GetCountAsync() > 0)
            {
                return;
            }

            var property = await _propertyRepository.InsertAsync(
                new Property
                {
                    Code = "PROP001",
                    AddressLine = "123 Main St, Springfield",
                    BuildingType = Enums.BuildingType.Apartment,
                    BuildingArea = 1200.5,
                    FloorNumber = 5,
                    Color = "#FF5733"
                },
                autoSave: true
            );

            if (property != null)
            {
                var householdDataFake = new Household
                {
                    Name = "Smith Family",
                    PropertyId = property.Id,
                    Property = property
                };
                
                await _householdRepository.InsertAsync(householdDataFake);
            }
        }
    }
}