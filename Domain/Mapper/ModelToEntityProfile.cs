using AutoMapper;
using Domain.Entities;
using Domain.Models;

namespace Domain.Mapper
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
