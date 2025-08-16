using System;
using Volo.Abp.Application.Dtos;

namespace ResiSecure.Households.Dtos
{
    public class HouseholdDto : AuditedEntityDto<Guid>
    {
        public string? Name { get; set; }
        public Guid PropertyId { get; set; }
        public Entities.Property? Property { get; set; }
    }
}
