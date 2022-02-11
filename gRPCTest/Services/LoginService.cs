
using gRPCTest.Protos;
using Grpc.Core;
using System.Threading.Tasks;
using Data.Repositories.User;
using AutoMapper;
using Domain.Entities.User;
using gRPCTest.Mapper.Interface;

namespace gRPCTest.Services
{
    public class LoginService : Login.LoginBase
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public LoginService(IUserRepository repository, IMapperGrpc mapper)
        {
            _repository = repository;
            _mapper = mapper.GetMapper();
        }

        public override async Task<UserLoginProDto> GetLogin(GetUserLoginRequest request, ServerCallContext context)
        {
            var result = await _repository.FindByLogin(_mapper.Map<UserEntity>(request));
            return _mapper.Map<UserLoginProDto>(result);
        }
    }
}
