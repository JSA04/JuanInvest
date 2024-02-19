using Api.Domain.Entities;

namespace Api.Repositories;

public interface IUserRepository 
{
    public Task<User?> GetUser(string userOrEmail, string password); 
    public Task RegisterUser(User user);
    public Task<bool> UserExists(string userOrEmail);
    public Task<IEnumerable<User>> ReadUsers(int pageNumber, int pageSize);
}