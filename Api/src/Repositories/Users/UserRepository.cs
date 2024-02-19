using System.Drawing;
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

    public async Task RegisterUser(User user)
    {
        await _infrastructure.Users.AddAsync(user);
        await _infrastructure.SaveChangesAsync();
    } 

    public async Task<bool> UserExists(string userOrEmail)
    {
        return await _infrastructure.Users.AsNoTracking()
            .FirstOrDefaultAsync(user => 
                (user.UserName == userOrEmail || user.Email == userOrEmail)
        ) != null; 
    }

    public async Task<IEnumerable<User>> ReadUsers (int pageNumber, int pageSize)
    {
        return await _infrastructure.Users.AsNoTracking()
            .OrderBy(u => u.UserName)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    } 
}