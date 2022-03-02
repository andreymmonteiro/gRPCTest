using Data.Context;
using Domain.Mapper.ConfigureAutoMapper;
using Domain.Mapper.Interface;
using gRPCTest.Mapper;
using gRPCTest.Mapper.Interface;
using gRPCTest.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Service.SigningAuthConfigutarion;
using System.Text;

namespace gRPCTest
{
    public class Startup
    {
        IConfiguration Configuration { get; }
        private const string TOKEN = "TokenKey";
        public Startup(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MyContext>(options => 
                                    options.UseMySql(Configuration.GetConnectionString("MySql"), 
                                                    ServerVersion.Parse("5.7-mysql")), ServiceLifetime.Transient);

            CreateAutoMapper(services);
            Cross_Cuttting.DependencyInjection.ConfigureServices.ConfigureIndependencyInjection(services);
            Cross_Cuttting.DependencyInjection.ConfigureRepository.ConfigureIndependencyInjection(services);
            
            ISigningConfigurations signingConfigurations = new SigningConfigurations();
            services.AddSingleton(signingConfigurations);

            services.AddGrpc();

            services.AddAuthentication(options => 
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options => 
                {
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = signingConfigurations.Key,
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });
            services.AddAuthorization();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapGrpcService<UserService>();
                
                endpoints.MapGrpcService<LoginService>();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
                });
            });
        }
        private void CreateAutoMapper(IServiceCollection services) 
        {

            services.AddTransient<IMapperGrpc, AutoMapperFixtureGrpc>();
            services.AddTransient<IMapperService, AutoMapperFixture>();
            services.AddAutoMapper(typeof(Startup));
        }
    }
}
