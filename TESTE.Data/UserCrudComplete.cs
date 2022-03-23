﻿using Data.Context;
using Data.Implementations;
using Domain.Entities.User;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TESTE.Data
{
    public class UserCrudComplete : IClassFixture<DbTest>
    {
        private MyContext context;
        private UserImplementation userImplementation;
        private UserEntity userEntity = new UserEntity()
        {
            Name = Faker.Name.FullName(),
            Age = 29,
            CompanyOrPerson= 'F',
            Document= Guid.NewGuid().ToString()
        };

        public UserCrudComplete(DbTest dbTest)
        {
            ServiceProvider serviceProvider = dbTest.serviceProvider;
            context = serviceProvider.GetService<MyContext>();
            userImplementation = new UserImplementation(context);
        }
        [Fact(DisplayName ="Can CRUD User")]
        public async Task CAN_CRUD_USER() 
        {
            await Insert();
            await Update();
            await Get();
            await Delete();
        }
        private async Task Insert() 
        {
            var result = await userImplementation.InsertAsync(userEntity);
            Test(userEntity, result);
            
        }
        private async Task Update() 
        {
            userEntity.Name = Faker.Name.FullName();
            var result = await userImplementation.UpdateAsync(userEntity);
            Assert.Equal(userEntity.Id, result.Id);
            Test(userEntity, result);
        }
        private async Task Delete() 
        {
            var result = await userImplementation.DeleteAsync(userEntity.Id);
            Assert.True(result);
        }
        private async Task Get() 
        {
            var resultGet = await userImplementation.SelectAsync(userEntity.Id);
            Test(userEntity, resultGet);
            var resultGetAll = await userImplementation.SelectAsync();
            Assert.True(resultGetAll.Count() > 0);
        }
        private void Test(UserEntity expected, UserEntity actual) 
        {
            Assert.True(actual != null);
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Age, actual.Age);
            Assert.Equal(expected.CompanyOrPerson, actual.CompanyOrPerson);
            Assert.Equal(expected.Document, actual.Document);
        }
        
    }
}
