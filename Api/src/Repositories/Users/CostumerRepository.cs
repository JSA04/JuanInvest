using System.Drawing;
using Api.Domain.Entities;
using Api.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories;

public class CostumerRepository : ICostumerRepository
{
    private readonly AppDbContext _infrastructure;

    public CostumerRepository (AppDbContext infrastructure) 
    {
        _infrastructure ??= infrastructure;
    }
    
    public async Task<Costumer?> GetCostumer(string cpfOrEmail, string password) 
    {
        return await _infrastructure.Costumers.AsNoTracking()
            .FirstOrDefaultAsync(Costumer => 
                (Costumer.Name == cpfOrEmail || Costumer.Email == cpfOrEmail) && 
                Costumer.Password == password
        ); 
    } 

    public async Task RegisterCostumer(Costumer Costumer)
    {
        await _infrastructure.Costumers.AddAsync(Costumer);
        await _infrastructure.SaveChangesAsync();
    } 

    public async Task<bool> CostumerExists(string CpfOrEmail)
    {
        return await _infrastructure.Costumers.AsNoTracking()
            .FirstOrDefaultAsync(Costumer => 
                (Costumer.Name == CpfOrEmail || Costumer.Email == CpfOrEmail)
        ) != null; 
    }

    public async Task<IEnumerable<Costumer>> ReadCostumers (int pageNumber, int pageSize)
    {
        return await _infrastructure.Costumers.AsNoTracking()
            .OrderBy(c => c.Name)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    } 
}