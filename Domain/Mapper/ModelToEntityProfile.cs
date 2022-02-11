using AutoMapper;
using Domain.Entities.User;
using Domain.Models.User;

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
