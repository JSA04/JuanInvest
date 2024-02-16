
using Api.Domain.Entities;

namespace Api.Repositories;

public interface IStockRepository
{
    public Task CreateStock(Stock stock);
    public Task<IEnumerable<Stock>> ReadStocks(int pageNumber, int pageSize);
    public Task<Stock?> GetStockById(string id);
    public bool StockExists(string id); 
    public Task UpdateStock(string id, Stock updatedStock);
    public Task DeleteStock(string id);
}