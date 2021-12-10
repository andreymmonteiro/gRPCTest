using AutoMapper;
using Domain.Dtos;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross_Cuttting.Mapper
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            User();
        }
        private void User() 
        {
            CreateMap<UserDto, UserEntity>().ReverseMap();
            CreateMap<UserCreateDto, UserEntity>().ReverseMap();
            CreateMap<UserCreateResultDto, UserEntity>().ReverseMap();
            CreateMap<UserUpdateDto, UserEntity>().ReverseMap();
            CreateMap<UserUpdateResultDto, UserEntity>().ReverseMap();
        }
    }
}
