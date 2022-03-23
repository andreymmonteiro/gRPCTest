using Domain.Dtos.User;
using Domain.Services.User;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace TESTE.Service
{
    public class CanCreateUser : BaseUser
    {
        [Fact]
        public async Task CAN_CREATE_USER() 
        {
            var userCreateDto = mapper.Map<UserCreateDto>(userEntity);
            UserCreateResultDto userCreateResultDto = mapper.Map<UserCreateResultDto>(userEntity);
            serviceMock = new Mock<IUserService>();
            serviceMock.Setup(setup => setup.Post(userCreateDto)).ReturnsAsync(userCreateResultDto);

            service = serviceMock.Object;

            var result = await service.Post(userCreateDto);
            Assert.NotNull(result);
            Assert.Equal(userCreateResultDto.Name, result.Name);
            Assert.Equal(userCreateResultDto.Id, result.Id);
            Assert.Equal(userCreateResultDto.Age, result.Age);
        }
    }
}
