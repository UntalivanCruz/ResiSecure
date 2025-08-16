using System;
using System.Collections.Generic;
using ResiSecure.Enums;
using Volo.Abp.Domain.Entities.Auditing;

namespace ResiSecure.Entities;

public class Property:AuditedAggregateRoot<Guid>
{
    public Guid? TenantId { get; set; }
    public string? Code { get; set; }
    public string? AddressLine { get; set; }
    public BuildingType BuildingType { get; set; }
    public double? BuildingArea { get; set; }
    public int FloorNumber { get; set; } = 1;
    public string? Color { get; set; }
    public ICollection<Household>? Households { get; set; }
}