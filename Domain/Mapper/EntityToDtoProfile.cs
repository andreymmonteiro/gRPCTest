﻿using AutoMapper;
using Domain.Dtos.User;
using Domain.Entities.User;

namespace Domain.Mapper
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
