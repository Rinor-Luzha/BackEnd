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
        public string Generate(int id, string email)
        {
            var symetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecureKey));
            var credentials = new SigningCredentials(symetricKey, SecurityAlgorithms.HmacSha256Signature);
            var header = new JwtHeader(credentials);
            var claims = new[]
            {
                new Claim("id",id.ToString()),
                new Claim("email",email)

            };
            var payload = new JwtPayload(null, null, claims, null, DateTime.UtcNow.AddHours(1));
            var securitytoken = new JwtSecurityToken(header, payload);

            return new JwtSecurityTokenHandler().WriteToken(securitytoken);
        }
        public JwtSecurityToken Verify(string jwt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            tokenHandler.ValidateToken(jwt, new TokenValidationParameters
            {
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecureKey)),
                ValidateIssuerSigningKey = true,
                ValidateIssuer = false,
                ValidateAudience = false,
            }, out SecurityToken validateToken);

            return (JwtSecurityToken)validateToken;
        }
    }
}
