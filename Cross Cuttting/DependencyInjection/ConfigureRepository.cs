using Data.Implementations;
using Data.Repositories;
using Data.Repositories.User;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross_Cuttting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void ConfigureIndependencyInjection(IServiceCollection service) 
        {
            service.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            service.AddScoped<IUserRepository, UserImplementation>();
        }
    }
}
