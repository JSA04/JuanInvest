
namespace Api.Controllers.Params;

public class RegisterUserBodyParams
{
    public required string UserName {get; set;} 
    public required string Email {get; set;}
    public required string Password {get; set;}
}