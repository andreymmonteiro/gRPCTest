
using AutoMapper;
using Data.Repositories.User;
using Domain.Entities.User;
using Domain.Services.Login;
using Grpc.Core;
using gRPCTest.Mapper.Interface;
using gRPCTest.Protos;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace gRPCTest.Services
{
    [Authorize]
    public class LoginService : Login.LoginBase
    {
        private readonly ILoginAuthService _service;
        private readonly IMapper _mapper;

        public LoginService(ILoginAuthService service, IMapperGrpc mapper)
        {
            _service = service;
            _mapper = mapper.GetMapper();
        }

        public override async Task<UserLoginProDto> GetLogin(GetUserLoginRequest request, ServerCallContext context)
        {
            var result = await _service.FindByLogin<UserEntity>(_mapper.Map<UserEntity>(request));
            return _mapper.Map<UserLoginProDto>(result);
        }
    }
}
