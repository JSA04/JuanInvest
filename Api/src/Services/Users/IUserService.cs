using Api.Domain;

namespace Api.Services;

public interface IUserService
{
    public Task<IServiceResult> Login(string userOrEmail, string password);
}