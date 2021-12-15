using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace TESTE.Data
{
    public class BaseTest
    {
        
    }
    public class DbTest : IDisposable
    {
        private string dbName = $"dbTest  {Guid.NewGuid().ToString().Replace("-", string.Empty)}";
        public ServiceProvider serviceProvider { get; private set;  }

        public DbTest()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<MyContext>(options =>
                options.UseMySql($"Persist Security Info=True;Server=localhost;Port=3306;Database={dbName};Uid=root;Pwd=masterkey", ServerVersion.Parse("5.7-mysql")),
                ServiceLifetime.Transient);
            serviceProvider = serviceCollection.BuildServiceProvider();
            using(var context = serviceProvider.GetService<MyContext>())
                context.Database.EnsureCreated();
        }

        public void Dispose()
        {
            using (var context = serviceProvider.GetService<MyContext>())
                context.Database.EnsureDeleted();
        }
    }
}
