using Domain.Models.Token;
using System;

namespace Domain.Services.Token
{
    public interface ITokenService
    {
        TokenModel GenerateToken(string username, DateTime createDate, DateTime expirionDate);
    }
}
