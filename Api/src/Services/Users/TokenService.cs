using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Api.Domain.Entities;
using Microsoft.IdentityModel.Tokens;

namespace Api.Services;

public class TokenService
{
    public static string GenerateToken(Costumer costumer)
    {
        // Definindo informações da autenticação.
        var tokenHandler = new JwtSecurityTokenHandler();

        // Chave secreta.
        var key = Environment.GetEnvironmentVariable("SECRET_KEY")
            ?? throw new KeyNotFoundException();
        var keyBytes = Encoding.ASCII.GetBytes(key);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity (new []
            {
                new Claim(ClaimTypes.Name, costumer.Name),
                new Claim(ClaimTypes.Email, costumer.Email),
                new Claim(ClaimTypes.Role, costumer.Role.ToString())
            }),
            
            // Tempo de expiração do token.
            
            Expires = DateTime.UtcNow.AddHours(1),
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256Signature)
        };

        // Token.
        var token = tokenHandler.CreateToken(tokenDescriptor);
        
        return tokenHandler.WriteToken(token); 
    }
}
