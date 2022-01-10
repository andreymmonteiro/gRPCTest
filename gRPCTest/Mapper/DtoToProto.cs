using AutoMapper;
using Domain.Dtos.User;
using gRPCTest.Protos;
using System.Collections.Generic;

namespace gRPCTest.Mapper
{
    public class DtoToProto : Profile
    {
        public DtoToProto()
        {
            CreateMap<UserDto, UserProDto>().ReverseMap();
            CreateMap<UserCreateDto, CreateUserRequest>().ReverseMap();
            CreateMap<UserCreateResultDto, UserCreateResultProtoDto>().ReverseMap();
            CreateMap<UserUpdateDto, UpdateUserRequest>().ReverseMap();
            CreateMap<UserUpdateResultDto, UserUpdateResultProtoDto>().ReverseMap();
            CreateMap<List<UserDto>, ListUserProDto>().ReverseMap();
        }
    }
}
