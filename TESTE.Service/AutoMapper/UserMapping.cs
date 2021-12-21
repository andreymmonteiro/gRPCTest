using Domain.Dtos;
using Domain.Entities;
using Domain.Mapper.ConfigureAutoMapper;
using Domain.Models;
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
            name = Faker.Name.FullName(),
            age = 29,
            companyOrPerson = 'F',
            document = Guid.NewGuid().ToString()
        };
        private UserModel userModel = new UserModel()
        {
            name = Faker.Name.FullName(),
            age = 29,
            companyOrPerson = 'F',
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

            Assert.Equal(userEntity.name, userDto.name);
            Assert.Equal(userEntity.age, userDto.age);
            Assert.Equal(userEntity.document, userDto.document);

            Assert.Equal(userEntity.name, userCreateDto.name);
            Assert.Equal(userEntity.age, userCreateDto.age);
            Assert.Equal(userEntity.document, userCreateDto.document);

            Assert.Equal(userEntity.name, userCreateDtoResult.name);
            Assert.Equal(userEntity.age, userCreateDtoResult.age);
            Assert.Equal(userEntity.document, userCreateDtoResult.document);

            Assert.Equal(userEntity.name, userUpdateDto.name);
            Assert.Equal(userEntity.age, userUpdateDto.age);
            Assert.Equal(userEntity.document, userUpdateDto.document);

            Assert.Equal(userEntity.name, userUpdateDtoResult.name);
            Assert.Equal(userEntity.age, userUpdateDtoResult.age);
            Assert.Equal(userEntity.document, userUpdateDtoResult.document);

            Assert.Equal(userEntity.name, userModelTest.name);
            Assert.Equal(userEntity.age, userModelTest.age);
            Assert.Equal(userEntity.document, userModelTest.document);
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

            Assert.Equal(userModel.name, userDto.name);
            Assert.Equal(userModel.age, userDto.age);
            Assert.Equal(userModel.document, userDto.document);

            Assert.Equal(userModel.name, userCreateDto.name);
            Assert.Equal(userModel.age, userCreateDto.age);
            Assert.Equal(userModel.document, userCreateDto.document);

            Assert.Equal(userModel.name, userCreateDtoResult.name);
            Assert.Equal(userModel.age, userCreateDtoResult.age);
            Assert.Equal(userModel.document, userCreateDtoResult.document);

            Assert.Equal(userModel.name, userUpdateDto.name);
            Assert.Equal(userModel.age, userUpdateDto.age);
            Assert.Equal(userModel.document, userUpdateDto.document);

            Assert.Equal(userModel.name, userUpdateDtoResult.name);
            Assert.Equal(userModel.age, userUpdateDtoResult.age);
            Assert.Equal(userModel.document, userUpdateDtoResult.document);

            Assert.Equal(userModel.name, userEntityTest.name);
            Assert.Equal(userModel.age, userEntityTest.age);
            Assert.Equal(userModel.document, userEntityTest.document);
        }

    }
}
