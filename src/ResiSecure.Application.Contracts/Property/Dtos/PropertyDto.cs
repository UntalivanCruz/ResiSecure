using System;
using ResiSecure.Enums;
using Volo.Abp.Application.Dtos;

namespace ResiSecure.Property.Dtos;

public class PropertyDto: AuditedEntityDto<Guid>
{
    public Guid? TenantId { get; set; }
    public string? Code { get; set; }
    public string? AddressLine { get; set; }
    public BuildingType BuildingType { get; set; }
    public double BuildingArea { get; set; }
    public int FloorNumber { get; set; } = 1;
    public string? Color { get; set; }
};