using AutoMapper;
using ResiSecure.Entities;
using ResiSecure.Households.Dtos;

namespace ResiSecure.Households
{
    public class HouseholdApplicationAutoMapperProfile : Profile
    {
        public HouseholdApplicationAutoMapperProfile()
        {
            CreateMap<Household, HouseholdDto>();
            CreateMap<CreateUpdateHouseholdDto, Household>();
        }
    }
}
