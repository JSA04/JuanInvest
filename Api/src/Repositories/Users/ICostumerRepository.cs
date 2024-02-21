using Api.Domain.Entities;

namespace Api.Repositories;

public interface ICostumerRepository 
{
    public Task<Costumer?> GetCostumer(string cpfOrEmail, string password); 
    public Task RegisterCostumer(Costumer costumer);
    public Task<bool> CostumerExists(string cpfOrEmail);
    public Task<IEnumerable<Costumer>> ReadCostumers(int pageNumber, int pageSize);
}