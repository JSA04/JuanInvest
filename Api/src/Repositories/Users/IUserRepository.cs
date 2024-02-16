using Api.Domain.Entities;

namespace Api.Repositories;

public interface IUserRepository 
{
    public Task<User?> GetUser(string userOrEmail, string password); 
}