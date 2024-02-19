
using System.Security.Cryptography;
using System.Text;

namespace Api.Services;

public class PasswordEncryptService
{
    public static string Encrypt(string password)
    {
        using (SHA256 sha = SHA256.Create())
        {
            string? secret_key = Environment.GetEnvironmentVariable("SECRET_KEY") ?? 
                throw new KeyNotFoundException("Chave secreta não encontrada para criptografia.");
            string salt = string.Concat(password[0], secret_key);

            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            byte[] combinedBytes = new byte[passwordBytes.Length + saltBytes.Length];
            Array.Copy(passwordBytes, 0, combinedBytes, 0, passwordBytes.Length);
            Array.Copy(saltBytes, 0, combinedBytes, passwordBytes.Length, saltBytes.Length);

            byte[] hashBytes = sha.ComputeHash(combinedBytes);

            StringBuilder builder = new StringBuilder();
            foreach (var hashByte in hashBytes)
            { 
                builder.Append(hashByte.ToString("x2")); 
            }
            
            return builder.ToString();
        }
    }

}
 