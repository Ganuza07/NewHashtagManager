using AutoMapper;
using NewHashtagManager.Domain.DTO;
using NewHashtagManager.Domain.Entities.Models;

namespace NewHashtagManager.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Posteo, PosteoDTO>().ReverseMap();
        }
    }
}