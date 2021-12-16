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
    public class CanDeleteUser : BaseUser
    {
        [Fact]
        public async Task CAN_DELETE_USER() 
        {
            serviceMock = new Mock<IUserService>();
            serviceMock.Setup(setup => setup.Delete(userEntity.id)).ReturnsAsync(true);
            service = serviceMock.Object;

            var result = await service.Delete(userEntity.id);
            Assert.True(result);
        }
    }
}
