using Domain.Models.Token;
using Domain.Services.Token;
using System;
using System.Threading.Tasks;

namespace Service
{
    public class TokenService : ITokenService
    {
        public TokenModel GenerateToken(string username, DateTime createDate, DateTime expirionDate)
        {
            return null;
        }
    }
}
