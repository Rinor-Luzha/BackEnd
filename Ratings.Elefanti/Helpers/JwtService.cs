using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Ratings.Elefanti.Helpers
{
    public class JwtService
    {
        private string SecureKey = "LIFE Gjirafa Second Phase Project";
        public string Generate(int Id, string Email)
        {
            var SymetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecureKey));
            var Credentials = new SigningCredentials(SymetricKey, SecurityAlgorithms.HmacSha256Signature);
            var Header = new JwtHeader(Credentials);
            var Claims = new[]
            {
                new Claim("id",Id.ToString()),
                new Claim("email",Email)

            };
            var Payload = new JwtPayload(null, null, Claims, null, DateTime.UtcNow.AddHours(1));
            var Securitytoken = new JwtSecurityToken(Header, Payload);

            return new JwtSecurityTokenHandler().WriteToken(Securitytoken);
        }
        public JwtSecurityToken Verify(string Jwt)
        {
            var TokenHandler = new JwtSecurityTokenHandler();
            TokenHandler.ValidateToken(Jwt, new TokenValidationParameters
            {
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecureKey)),
                ValidateIssuerSigningKey = true,
                ValidateIssuer = false,
                ValidateAudience = false,
            }, out SecurityToken ValidateToken);

            return (JwtSecurityToken)ValidateToken;
        }
    }
}
