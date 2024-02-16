using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Api.Domain.Entities;
using Microsoft.IdentityModel.Tokens;

namespace Api.Services;

public class TokenService
{
    public static string GenerateToken(User user)
    {
        // Definindo informações da autenticação.
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Role, user.Role)
        };
        
        // Chave secreta.
        var stringKey = Environment.GetEnvironmentVariable("authSecretKey");
        if (stringKey is null)
            throw new KeyNotFoundException();
        var key =
            new SymmetricSecurityKey(
                Encoding.ASCII.GetBytes(stringKey)
            );
        
        var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
        
        // Tempo de expiração do token.
        var expires = DateTime.UtcNow.AddHours(1);
        
        // Token.
        var token = new JwtSecurityToken(
            claims: claims,
            expires: expires,
            signingCredentials: cred
        );

        return token.ToString();
    }
}
