using Domain.Services.Login;
using Domain.Services.Token;
using Domain.Services.User;
using Microsoft.Extensions.DependencyInjection;
using Service;
using Service.SigningAuthConfigutarion;

namespace Cross_Cuttting.DependencyInjection
{
    public static class ConfigureServices
    {
        public static void ConfigureIndependencyInjection(IServiceCollection service) 
        {
            service.AddScoped<ILoginAuthService, LoginAuthService>();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<ITokenService, TokenService>();
        }
    }
}
