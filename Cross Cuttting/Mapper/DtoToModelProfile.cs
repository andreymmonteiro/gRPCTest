using AutoMapper;
using Domain.Dtos;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross_Cuttting.Mapper
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            User();
        }

        private void User()
        {
            CreateMap<UserDto, UserModel>().ReverseMap();
            CreateMap<UserCreateDto, UserModel>().ReverseMap();
            CreateMap<UserCreateResultDto, UserModel>().ReverseMap();
            CreateMap<UserUpdateDto, UserModel>().ReverseMap();
            CreateMap<UserUpdateResultDto, UserModel>().ReverseMap();
        }
    }
    
}
