
namespace Api.Controllers.Params;

public class LoginCostumerParams
{
    public required string CpfOrEmail {get; set;}
    public required string Password {get; set;}
}