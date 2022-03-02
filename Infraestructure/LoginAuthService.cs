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
        private const int Seconds = 3000;

        public LoginAuthService(ITokenService service, IUserRepository repository)
        {
            _tokenService = service;
            _repository = repository;
        }

        public async Task<T> FindByLogin<T>(UserEntity user) where T : class
        {
            return await _repository.FindByLogin(user) as T;
        }

        public Domain.Models.Token.TokenModel GenerateToken(string email, DateTime createDate)
        {
            return _tokenService.GenerateToken(email, createDate, createDate + TimeSpan.FromSeconds(Seconds));
        }
    }
}
