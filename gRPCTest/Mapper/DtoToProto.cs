using AutoMapper;
using Domain.Dtos;
using gRPCTest.Protos;

namespace gRPCTest.Mapper
{
    public class DtoToProto : Profile
    {
        public DtoToProto()
        {
            CreateMap<UserDto, UserProDto>().ReverseMap();
            CreateMap<UserCreateDto, CreateUserRequest>().ReverseMap();
            CreateMap<UserCreateResultDto, UserCreateResultProtoDto>();
        }
    }
}
