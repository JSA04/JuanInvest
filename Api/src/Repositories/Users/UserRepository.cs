using Api.Domain.Entities;
using Api.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _infrastructure;

    public UserRepository (AppDbContext infrastructure) 
    {
        _infrastructure ??= infrastructure;
    }
    
    public async Task<User?> GetUser(string userOrEmail, string password) 
    {
        return await _infrastructure.Users.AsNoTracking()
            .FirstOrDefaultAsync(user => 
                (user.UserName == userOrEmail || user.Email == userOrEmail) && 
                user.Password == password
        ); 
    } 
}