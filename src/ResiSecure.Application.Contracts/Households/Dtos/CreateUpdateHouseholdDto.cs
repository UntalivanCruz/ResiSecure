using System;
using System.ComponentModel.DataAnnotations;

namespace ResiSecure.Households.Dtos
{
    public class CreateUpdateHouseholdDto
    {
        [Required]
        [StringLength(128)]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        public Guid PropertyId { get; set; }
    }
}
