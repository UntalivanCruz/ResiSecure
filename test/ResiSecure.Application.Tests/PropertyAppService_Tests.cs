using System.Linq;
using System.Threading.Tasks;
using ResiSecure.Property;
using ResiSecure.Property.Dtos;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Modularity;
using Volo.Abp.Validation;
using Xunit;

namespace ResiSecure;

public abstract class PropertyAppService_Tests<TStartupModule> : ResiSecureApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
    private readonly IPropertyAppService _propertyAppService;

    protected PropertyAppService_Tests()
    {
        _propertyAppService = GetRequiredService<IPropertyAppService>();
    }
    
    [Fact]
    public async Task Should_Get_List_Of_Properties()
    {
        // Arrange
        var request = new PagedAndSortedResultRequestDto
        {
            MaxResultCount = 10,
            SkipCount = 0,
            Sorting = "Code"
        };

        // Act
        var result = await _propertyAppService.GetListAsync(request);

        // Assert
        Assert.NotNull(result);
        Assert.NotEmpty(result.Items);
        result.TotalCount.ShouldBeGreaterThan(0);
        result.Items.ShouldContain(b => b.Code == "PROP001");
    }
    
    [Fact]
    public async Task Should_Create_A_Valid_Property()
    {
        // Arrange
        var newCode= "PROP003";
        // Act
        var createdProperty = await CreateProperty(newCode);

        // Assert
        Assert.NotNull(createdProperty);
        createdProperty.Code.ShouldBe(newCode);
        createdProperty.AddressLine.ShouldBe("456 Elm St, Springfield");
    }

    [Fact]
    public async Task Should_Get_Property_By_Id()
    {
        // Arrange
        var listResult = await _propertyAppService.GetListAsync(new PagedAndSortedResultRequestDto());
        var propertyId = listResult.Items.First().Id;

        // Act
        var result = await _propertyAppService.GetAsync(propertyId);

        // Assert
        result.ShouldNotBeNull();
        result.Code.ShouldBe("PROP001");
        result.AddressLine.ShouldBe("123 Main St, Springfield");
    }
    
    [Fact]
    public async Task Should_Update_Property()
    {
        // Arrange
        var listResult = await _propertyAppService.GetListAsync(new PagedAndSortedResultRequestDto());
        var propertyId = listResult.Items.First().Id;

        var updateProperty = new CreateUpdatePropertyDto
        {
            Code = "PROP001-UPDATED",
            AddressLine = "123 Main St, Springfield Updated",
            BuildingType = Enums.BuildingType.Townhouse,
            BuildingArea = 1300.0,
            FloorNumber = 2,
            Color = "Green"
        };

        // Act
        var updatedProperty = await _propertyAppService.UpdateAsync(propertyId, updateProperty);

        // Assert
        updatedProperty.ShouldNotBeNull();
        updatedProperty.Code.ShouldBe("PROP001-UPDATED");
        updatedProperty.AddressLine.ShouldBe("123 Main St, Springfield Updated");
    }
    
    [Fact]
    public async Task Should_Delete_Property()
    {
        // Arrange
        var recordToDelete = await CreateProperty();

        // Act
        await _propertyAppService.DeleteAsync(recordToDelete.Id);

        // Assert
        var listResult = await _propertyAppService.GetListAsync(new PagedAndSortedResultRequestDto());
        listResult.Items.Any(p => p.Id == recordToDelete.Id).ShouldBeFalse();
    }

    private async Task<PropertyDto> CreateProperty(string code = "PROP002")
    {
        var newProperty = new CreateUpdatePropertyDto
        {
            Code = code,
            AddressLine = "456 Elm St, Springfield",
            BuildingType = Enums.BuildingType.SingleFamilyHome,
            BuildingArea = 1500.0,
            FloorNumber = 1,
            Color = "Red"
        };
        var createdProperty = await _propertyAppService.CreateAsync(newProperty);
        return createdProperty;
    }
        
}