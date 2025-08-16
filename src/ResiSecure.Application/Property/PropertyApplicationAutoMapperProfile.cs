using AutoMapper;
using ResiSecure.Property.Dtos;

namespace ResiSecure.Property;

public class PropertyApplicationAutoMapperProfile: Profile
{
    public PropertyApplicationAutoMapperProfile()
    {
        CreateMap<Entities.Property, PropertyDto>();
        CreateMap<CreateUpdatePropertyDto, Entities.Property>();
    }
}