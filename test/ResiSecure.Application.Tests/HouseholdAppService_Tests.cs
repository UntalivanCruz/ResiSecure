using System;
using System.Linq;
using System.Threading.Tasks;
using ResiSecure.Households;
using ResiSecure.Households.Dtos;
using ResiSecure.Property;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Modularity;
using Xunit;

namespace ResiSecure;

public abstract class HouseholdAppService_Tests<TStartupModule> : ResiSecureApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
    private readonly IHouseholdAppService _householdAppService;
    private readonly IPropertyAppService _propertyAppService;

    protected HouseholdAppService_Tests()
    {
        _householdAppService = GetRequiredService<IHouseholdAppService>();
        _propertyAppService = GetRequiredService<IPropertyAppService>();
    }
    
    [Fact]
    public async Task Should_Get_List_Of_Households()
    {
        // Arrange
        var request = new PagedAndSortedResultRequestDto
        {
            MaxResultCount = 10,
            SkipCount = 0,
            Sorting = "Name"
        };

        // Act
        var result = await _householdAppService.GetListAsync(request);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result.Items);
        result.TotalCount.ShouldBeGreaterThan(0);
        result.Items.ShouldContain(h => h.Name == "Smith Family");
    }
    
    [Fact]
    public async Task Should_Create_A_Valid_Household()
    {
        // Arrange
        var newName = "Familia Gómez";
        var propertyId = await GetFirstPropertyId();
        // Act
        var createdHousehold = await CreateHousehold(newName, propertyId);

        // Assert
        Assert.NotNull(createdHousehold);
        createdHousehold.Name.ShouldBe(newName);
        createdHousehold.PropertyId.ShouldBe(propertyId);
    }

    [Fact]
    public async Task Should_Get_Household_By_Id()
    {
        // Arrange
        var listResult = await _householdAppService.GetListAsync(new PagedAndSortedResultRequestDto());
        var householdId = listResult.Items.First().Id;

        // Act
        var result = await _householdAppService.GetAsync(householdId);

        // Assert
        result.ShouldNotBeNull();
        result.Name.ShouldBe("Smith Family");
    }
    
    [Fact]
    public async Task Should_Update_Household()
    {
        // Arrange
        var listResult = await _householdAppService.GetListAsync(new PagedAndSortedResultRequestDto());
        var householdId = listResult.Items.First().Id;
        var propertyId = await GetFirstPropertyId();

        var updateHousehold = new CreateUpdateHouseholdDto
        {
            Name = "Familia Pérez Actualizada",
            PropertyId = propertyId
        };

        // Act
        var updatedHousehold = await _householdAppService.UpdateAsync(householdId, updateHousehold);

        // Assert
        updatedHousehold.ShouldNotBeNull();
        updatedHousehold.Name.ShouldBe("Familia Pérez Actualizada");
    }
    
    [Fact]
    public async Task Should_Delete_Household()
    {
        // Arrange
        var propertyId = await GetFirstPropertyId();
        var recordToDelete = await CreateHousehold("Familia Temporal", propertyId);

        // Act
        await _householdAppService.DeleteAsync(recordToDelete.Id);

        // Assert
        var listResult = await _householdAppService.GetListAsync(new PagedAndSortedResultRequestDto());
        listResult.Items.Any(h => h.Id == recordToDelete.Id).ShouldBeFalse();
    }

    private async Task<HouseholdDto> CreateHousehold(string name = "Familia Test", Guid? propertyId = null)
    {
        var propId = propertyId ?? await GetFirstPropertyId();
        var newHousehold = new CreateUpdateHouseholdDto
        {
            Name = name,
            PropertyId = propId
        };
        var createdHousehold = await _householdAppService.CreateAsync(newHousehold);
        return createdHousehold;
    }

    private async Task<Guid> GetFirstPropertyId()
    {
        var listResult = await _propertyAppService.GetListAsync(new PagedAndSortedResultRequestDto());
        return listResult.Items.First().Id;
    }
}