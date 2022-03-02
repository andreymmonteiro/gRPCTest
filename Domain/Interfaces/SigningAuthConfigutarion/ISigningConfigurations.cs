using Microsoft.IdentityModel.Tokens;

namespace Service.SigningAuthConfigutarion
{
    public interface ISigningConfigurations
    {
        SecurityKey Key { get; set; }
        SigningCredentials SigningCredentials { get; set; }
    }
}
