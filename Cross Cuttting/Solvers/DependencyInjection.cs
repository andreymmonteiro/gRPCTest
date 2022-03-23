using Data.Repositories;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Cross_Cuttting.Solvers
{
    public static class DependencyInjection
    {
        public static void Repositories(IServiceCollection service) 
        {
            service.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
        }
    }
}
