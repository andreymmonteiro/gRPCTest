using AutoMapper;
using Domain.Entities.User;
using Domain.Mapper.ConfigureAutoMapper;
using Domain.Services.User;
using Moq;
using System;

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
