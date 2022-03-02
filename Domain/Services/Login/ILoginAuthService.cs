using Domain.Entities.User;
using Domain.Models.Token;
using System;
using System.Threading.Tasks;

namespace Domain.Services.Login
{
    public interface ILoginAuthService
    {
        Task<T> FindByLogin<T>(UserEntity user) where T : class;

        TokenModel GenerateToken(string email, DateTime createDate);
    }
}
