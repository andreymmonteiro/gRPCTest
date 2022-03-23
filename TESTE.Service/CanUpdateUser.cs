using Domain.Dtos.User;
using Domain.Services.User;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace TESTE.Service
{
    public class CanUpdateUser : BaseUser
    {
        [Fact]
        public async Task CAN_UPDATE_USER() 
        {
            UserUpdateDto userUpdateDto = mapper.Map<UserUpdateDto>(userEntity);
            UserUpdateResultDto userUpdateResultDto = mapper.Map<UserUpdateResultDto>(userEntity);
            serviceMock = new Mock<IUserService>();
            serviceMock.Setup(setup => setup.Put(userUpdateDto)).ReturnsAsync(userUpdateResultDto);
            service = serviceMock.Object;

            var result = await service.Put(userUpdateDto);
            Assert.NotNull(result);
            Assert.Equal(userUpdateResultDto.Name, result.Name);
            Assert.Equal(userUpdateResultDto.Age, result.Age);
            Assert.Equal(userUpdateResultDto.Document, result.Document);
        }
    }
}
