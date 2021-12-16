using Domain.Dtos;
using Domain.Services.User;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TESTE.Service
{
    public class CanGetUser : BaseUser
    {
        [Fact]
        public async Task CAN_GET_USER() 
        {
            UserDto userDto = mapper.Map<UserDto>(userEntity);
            serviceMock = new Mock<IUserService>();
            serviceMock.Setup(setup => setup.Get(userEntity.id)).ReturnsAsync(userDto);
            service = serviceMock.Object;

            var result = await service.Get(userEntity.id);

            Assert.NotNull(result);
            Assert.Equal(userDto.name, result.name);
            Assert.Equal(userDto.id, result.id);
            Assert.Equal(userDto.document, result.document);
            Assert.Equal(userDto.age, result.age);

            List<UserDto> userDtos = new List<UserDto> { userDto };
            serviceMock.Setup(setup => setup.Get()).ReturnsAsync(userDtos);
            service = serviceMock.Object;
            var resultDtos = await service.Get();
            Assert.NotNull(resultDtos);
            Assert.True(resultDtos.Count() > 0);
        }
    }
}
