using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace ResiSecure.Entities;

public class Household:AuditedAggregateRoot<Guid>
{
    public Guid? TenantId { get; set; }
    public string? Name { get; set; }
    public Guid PropertyId { get; set; }
    public Property? Property { get; set; }
}