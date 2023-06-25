using AutoMapper;
using OccasionInvitation.Domain.Entites;
using OccasionInvitation.Models.DTOs;

namespace OccasionInvitation.Models.AutoMapperProfiler
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Person, PersonDTO>();
        }
    }
}
