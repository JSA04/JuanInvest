
namespace Api.Services;

public interface IUserService
{
    public Task<IServiceResult> UserLogin(string userOrEmail, string password);
    public Task<IServiceResult> UserRegister(string user, string email, string password);
    public Task<IServiceResult> ReadUsers(int pageNumber, int pageSize); 
}