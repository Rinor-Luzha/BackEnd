using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Ratings.Elefanti.Helpers
{
    public class JwtService
    {
        private string SecureKey = "LIFE Gjirafa Second Phase Project";
        public string Generate(int Id)
        {
            var SymetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecureKey));
            var Credentials = new SigningCredentials(SymetricKey, SecurityAlgorithms.HmacSha256Signature);
            var Header = new JwtHeader(Credentials);
            var Payload = new JwtPayload(Id.ToString(), null, null, null, DateTime.Today.AddDays(1));
            var Securitytoken = new JwtSecurityToken(Header, Payload);

            return new JwtSecurityTokenHandler().WriteToken(Securitytoken);
        }
        public JwtSecurityToken Verify(string Jwt)
        {
            var TokenHandler = new JwtSecurityTokenHandler();
            var Key=Encoding.ASCII.GetBytes(SecureKey);
            TokenHandler.ValidateToken(Jwt, new TokenValidationParameters
            {
                IssuerSigningKey = new SymmetricSecurityKey(Key),
                ValidateIssuerSigningKey = true,
                ValidateIssuer = false,
                ValidateAudience = false,
            }, out SecurityToken ValidateToken);

            return (JwtSecurityToken)ValidateToken;
        }
    }
}
