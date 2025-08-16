using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResiSecure.Entities;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ResiSecure.Configurations;

public class HouseHoldConfiguration: IEntityTypeConfiguration<Household>
{
    public void Configure(EntityTypeBuilder<Household> builder)
    {
        builder.ToTable($"{ResiSecureConsts.DbTablePrefix}Households", ResiSecureConsts.DbSchema);
        builder.ConfigureByConvention();
        builder.HasKey(h => h.Id);
        builder.Property(h => h.Name).IsRequired().HasMaxLength(200);
        builder.HasOne(h => h.Property)
               .WithMany(p => p.Households)
               .HasForeignKey(h => h.PropertyId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}