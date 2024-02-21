namespace Api.Domain.Entities;

public class Costumer
{

    public required string Id { get; set; }
    public required string Cpf { get; set; } 
    public required string Name { get; set;  }
    public required string Surname { get; set;  }
    public required string Email { get; set; } 
    public required string Password { get; set; }
    public required string Role { get; set; }
}