
namespace Api.Controllers.Params;

public class RegisterCostumerParams
{
    public required string Cpf { get; set; } 
    public required string Name { get; set;  }
    public required string Surname { get; set;  }
    public required string Email { get; set; } 
    public required string Password { get; set; }
}