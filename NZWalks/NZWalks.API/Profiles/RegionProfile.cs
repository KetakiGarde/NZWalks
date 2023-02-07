using AutoMapper;

namespace NZWalks.API.Profiles
{
    public class RegionProfile : Profile
    {
        CreateMap<Models.Domain.Region, Models.DTO.Region>()
            .ReverseMap();
    }
}
