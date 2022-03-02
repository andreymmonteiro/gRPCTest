using Domain.Models.Token;
using Domain.Services.Token;
using Microsoft.IdentityModel.Tokens;
using Service.SigningAuthConfigutarion;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;

namespace Service
{
    public class TokenService : ITokenService
    {
        private readonly ISigningConfigurations signingConfigurations;

        public TokenService(ISigningConfigurations signingConfigurations)
        {
            this.signingConfigurations = signingConfigurations;
        }

        public TokenModel GenerateToken(string username, DateTime createDate, DateTime expirionDate)
        {
            var handler = new JwtSecurityTokenHandler();
            ClaimsIdentity identity = CreateClaim(username);
            var securityToken = CreateSecurityToken(identity, createDate, expirionDate, handler);
            var token = handler.WriteToken(securityToken);
            return new TokenModel() { AccessToken = token};
        }

        private ClaimsIdentity CreateClaim(string username)
        {
            return new ClaimsIdentity(new GenericIdentity(username), new[]
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName, username)
            });
        }

        private SecurityToken CreateSecurityToken(ClaimsIdentity identity, DateTime createDate, DateTime expirionDate, JwtSecurityTokenHandler handler)
        {
            return handler.CreateToken(new SecurityTokenDescriptor()
            {
                SigningCredentials = signingConfigurations.SigningCredentials,
                Subject = identity,
                NotBefore = createDate,
                Expires = expirionDate
            });
        }
    }
}
