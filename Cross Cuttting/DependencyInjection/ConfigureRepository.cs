using Data.Implementations;
using Data.Repositories;
using Data.Repositories.User;
using Domain.Interfaces;
using Domain.Services.User;
using Microsoft.Extensions.DependencyInjection;
using Service;

namespace Cross_Cuttting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureIndependencyInjection(IServiceCollection service) 
        {
            service.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            service.AddScoped<IUserRepository, UserImplementation>();
            service.AddScoped<IUserService, UserService>();
        }
    }
}
