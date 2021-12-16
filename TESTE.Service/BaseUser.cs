using AutoMapper;
using Cross_Cuttting.Mapper.ConfigureAutoMapper;
using Domain.Entities;
using Domain.Services.User;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE.Service
{
    public abstract class BaseUser
    {
        protected Mock<IUserService> serviceMock;
        protected IUserService service;
        protected IMapper mapper;
        protected UserEntity userEntity { get; set; }

        protected BaseUser()
        {
            mapper = new AutoMapperFixture().GetMapper();
            userEntity = new UserEntity() 
            {
                id = Guid.NewGuid(),
                name = Faker.Name.FullName(),
                age = 29,
                companyOrPerson = 'F',
                document = Guid.NewGuid().ToString()
            };
        }
    }
}
