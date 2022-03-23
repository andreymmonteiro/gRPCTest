using Domain.Dtos.User;
using Domain.Services.User;
using Moq;
using System.Collections.Generic;
using System.Linq;
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
            serviceMock.Setup(setup => setup.Get(userEntity.Id)).ReturnsAsync(userDto);
            service = serviceMock.Object;

            var result = await service.Get(userEntity.Id);

            Assert.NotNull(result);
            Assert.Equal(userDto.Name, result.Name);
            Assert.Equal(userDto.Id, result.Id);
            Assert.Equal(userDto.Document, result.Document);
            Assert.Equal(userDto.Age, result.Age);

            List<UserDto> userDtos = new List<UserDto> { userDto };
            serviceMock.Setup(setup => setup.Get()).ReturnsAsync(userDtos);
            service = serviceMock.Object;
            var resultDtos = await service.Get();
            Assert.NotNull(resultDtos);
            Assert.True(resultDtos.Count() > 0);
        }
    }
}
