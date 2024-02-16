namespace Api.Domain.Entities;

public class User
{
    public required string UserName { get; set;  }
    public required string Email { get; set; } 
    public required string Password { get; set; }
    public required string Role { get; set; }
}