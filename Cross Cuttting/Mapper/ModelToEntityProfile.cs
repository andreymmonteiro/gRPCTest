using AutoMapper;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross_Cuttting.Mapper
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            User();
        }
        private void User() 
        {
            CreateMap<UserModel, UserEntity>().ReverseMap();        
        }
    }
}
