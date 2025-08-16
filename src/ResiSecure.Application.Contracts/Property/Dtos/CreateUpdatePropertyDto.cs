using System.ComponentModel.DataAnnotations;
using ResiSecure.Enums;

namespace ResiSecure.Property.Dtos;

public record CreateUpdatePropertyDto()
{
    [StringLength(50)]
    public string Code { get; set; } = string.Empty;
    
    [StringLength(500)]
    public string AddressLine { get; set; } = string.Empty;
    
    public BuildingType BuildingType { get; set; }
    public double? BuildingArea { get; set; }
    public int FloorNumber { get; set; } = 1;
    
    [StringLength(8)]
    public string Color { get; set; } = string.Empty;
}