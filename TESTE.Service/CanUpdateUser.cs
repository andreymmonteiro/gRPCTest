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
            Assert.Equal(userUpdateResultDto.name, result.name);
            Assert.Equal(userUpdateResultDto.age, result.age);
            Assert.Equal(userUpdateResultDto.document, result.document);
        }
    }
}
