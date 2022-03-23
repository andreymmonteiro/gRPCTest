using AutoMapper;
using Domain.Entities.User;
using Domain.Services.Login;
using Grpc.Core;
using gRPCTest.Mapper.Interface;
using gRPCTest.Protos;
using System;
using System.Threading.Tasks;

namespace gRPCTest.Services
{
    public class LoginService : Login.LoginBase
    {
        private readonly ILoginAuthService _service;
        private readonly IMapper _mapper;
        private readonly DateTime _now;

        public LoginService(ILoginAuthService service, IMapperGrpc mapper)
        {
            _service = service;
            _mapper = mapper.GetMapper();
            _now = DateTime.Now;
        }

        public override async Task<UserLoginProDto> GetLogin(GetUserLoginRequest request, ServerCallContext context)
        {
            var result = await _service.FindByLogin<UserEntity>(_mapper.Map<UserEntity>(request));
            var userLoginProDto = _mapper.Map<UserLoginProDto>(result);
            userLoginProDto.Token = _service.GenerateToken(result.Email, _now).AccessToken;
            return userLoginProDto;
        }
    }
}
