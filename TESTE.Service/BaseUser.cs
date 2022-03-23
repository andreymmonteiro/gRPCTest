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
                Id = Guid.NewGuid(),
                Name = Faker.Name.FullName(),
                Age = 29,
                CompanyOrPerson = 'F',
                Document = Guid.NewGuid().ToString()
            };
        }
    }
}
