using Domain.Dtos.User;
using Domain.Entities.User;
using Domain.Mapper.ConfigureAutoMapper;
using Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TESTE.Service.AutoMapper
{
    public class UserMapping 
    {
        private UserEntity userEntity = new UserEntity()
        {
            Name = Faker.Name.FullName(),
            Age = 29,
            CompanyOrPerson = 'F',
            Document = Guid.NewGuid().ToString()
        };
        private UserModel userModel = new UserModel()
        {
            Name = Faker.Name.FullName(),
            Age = 29,
            CompanyOrPerson = 'F',
        };


        [Fact(DisplayName ="Can map User entity")]
        public async Task CAN_MAP_USER_ENTITY() 
        {
            var mapper = new AutoMapperFixture().GetMapper();
            var userDto = mapper.Map<UserDto>(userEntity);
            var userCreateDto = mapper.Map<UserCreateDto>(userEntity);
            var userCreateDtoResult = mapper.Map<UserCreateResultDto>(userEntity);
            var userUpdateDto = mapper.Map<UserUpdateDto>(userEntity);
            var userUpdateDtoResult = mapper.Map<UserUpdateResultDto>(userEntity);
            var userModelTest = mapper.Map<UserModel>(userEntity);

            Assert.NotNull(userDto);
            Assert.NotNull(userCreateDto);
            Assert.NotNull(userCreateDtoResult);
            Assert.NotNull(userUpdateDto);
            Assert.NotNull(userUpdateDtoResult);
            Assert.NotNull(userModelTest);

            Assert.Equal(userEntity.Name, userDto.Name);
            Assert.Equal(userEntity.Age, userDto.Age);
            Assert.Equal(userEntity.Document, userDto.Document);

            Assert.Equal(userEntity.Name, userCreateDto.Name);
            Assert.Equal(userEntity.Age, userCreateDto.Age);
            Assert.Equal(userEntity.Document, userCreateDto.Document);

            Assert.Equal(userEntity.Name, userCreateDtoResult.Name);
            Assert.Equal(userEntity.Age, userCreateDtoResult.Age);
            Assert.Equal(userEntity.Document, userCreateDtoResult.Document);

            Assert.Equal(userEntity.Name, userUpdateDto.Name);
            Assert.Equal(userEntity.Age, userUpdateDto.Age);
            Assert.Equal(userEntity.Document, userUpdateDto.Document);

            Assert.Equal(userEntity.Name, userUpdateDtoResult.Name);
            Assert.Equal(userEntity.Age, userUpdateDtoResult.Age);
            Assert.Equal(userEntity.Document, userUpdateDtoResult.Document);

            Assert.Equal(userEntity.Name, userModelTest.Name);
            Assert.Equal(userEntity.Age, userModelTest.Age);
            Assert.Equal(userEntity.Document, userModelTest.Document);
        }
        [Fact(DisplayName ="Can map user model")]
        public async Task CAN_MAP_USER_MODEL() 
        {
            var mapper = new AutoMapperFixture().GetMapper();
            var userDto = mapper.Map<UserDto>(userModel);
            var userCreateDto = mapper.Map<UserCreateDto>(userModel);
            var userCreateDtoResult = mapper.Map<UserCreateResultDto>(userModel);
            var userUpdateDto = mapper.Map<UserUpdateDto>(userModel);
            var userUpdateDtoResult = mapper.Map<UserUpdateResultDto>(userModel);
            var userEntityTest = mapper.Map<UserEntity>(userModel);

            Assert.NotNull(userDto);
            Assert.NotNull(userCreateDto);
            Assert.NotNull(userCreateDtoResult);
            Assert.NotNull(userUpdateDto);
            Assert.NotNull(userUpdateDtoResult);
            Assert.NotNull(userEntityTest);

            Assert.Equal(userModel.Name, userDto.Name);
            Assert.Equal(userModel.Age, userDto.Age);
            Assert.Equal(userModel.Document, userDto.Document);

            Assert.Equal(userModel.Name, userCreateDto.Name);
            Assert.Equal(userModel.Age, userCreateDto.Age);
            Assert.Equal(userModel.Document, userCreateDto.Document);

            Assert.Equal(userModel.Name, userCreateDtoResult.Name);
            Assert.Equal(userModel.Age, userCreateDtoResult.Age);
            Assert.Equal(userModel.Document, userCreateDtoResult.Document);

            Assert.Equal(userModel.Name, userUpdateDto.Name);
            Assert.Equal(userModel.Age, userUpdateDto.Age);
            Assert.Equal(userModel.Document, userUpdateDto.Document);

            Assert.Equal(userModel.Name, userUpdateDtoResult.Name);
            Assert.Equal(userModel.Age, userUpdateDtoResult.Age);
            Assert.Equal(userModel.Document, userUpdateDtoResult.Document);

            Assert.Equal(userModel.Name, userEntityTest.Name);
            Assert.Equal(userModel.Age, userEntityTest.Age);
            Assert.Equal(userModel.Document, userEntityTest.Document);
        }

    }
}
