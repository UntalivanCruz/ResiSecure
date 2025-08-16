using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResiSecure.Entities;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ResiSecure.Configurations;

public class PropertyConfiguration: IEntityTypeConfiguration<Property>
{
    public void Configure(EntityTypeBuilder<Property> builder)
    { 
        builder.ToTable($"{ResiSecureConsts.DbTablePrefix}Properties", ResiSecureConsts.DbSchema);
        builder.ConfigureByConvention();
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Code).HasMaxLength(50);
        builder.Property(p => p.AddressLine).HasMaxLength(500);
        builder.Property(p => p.BuildingType).IsRequired();
        builder.Property(p => p.FloorNumber).IsRequired().HasDefaultValue(1);
        builder.Property(p => p.Color).HasMaxLength(8);
        builder.HasMany(p => p.Households)
               .WithOne(h => h.Property)
               .HasForeignKey(h => h.PropertyId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}