using Data.Repositories.User;
using Domain.Entities.User;
using Domain.Services.Login;
using Domain.Services.Token;
using System;
using System.Threading.Tasks;

namespace Service
{
    public class LoginAuthService : ILoginAuthService
    {
        private readonly ITokenService _tokenService;
        private readonly IUserRepository _repository;
        private readonly DateTime _now;
        private const int Seconds = 3000;

        public LoginAuthService(ITokenService service, IUserRepository repository)
        {
            _tokenService = service;
            _repository = repository;
            _now = DateTime.Now;
        }

        public async Task<T> FindByLogin<T>(UserEntity user) where T : class
        {
            var userEntity = await _repository.FindByLogin(user);
            var tokenModel = _tokenService.GenerateToken(user.email, _now, _now + TimeSpan.FromSeconds(Seconds));
            return tokenModel as T;
        }
    }
}
