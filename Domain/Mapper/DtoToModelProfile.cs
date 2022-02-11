using AutoMapper;
using Domain.Dtos.User;
using Domain.Models.User;

namespace Domain.Mapper
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
