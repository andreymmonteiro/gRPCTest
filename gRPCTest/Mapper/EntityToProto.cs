using AutoMapper;
using Domain.Entities.User;
using gRPCTest.Protos;

namespace gRPCTest.Mapper
{
    public class EntityToProto : Profile
    {
        public EntityToProto() 
        {
            CreateMap<UserEntity, GetUserLoginRequest>().ForMember(destiny => destiny.UserName, options => options.MapFrom(resource => resource.Email)).ReverseMap();
            CreateMap<UserEntity, UserLoginProDto>().ReverseMap();
        }
    }
}
