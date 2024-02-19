
namespace Api.Controllers.Params;

public class LoginUserBodyParams
{
    public required string UserOrEmail {get; set;}
    public required string Password {get; set;}
}