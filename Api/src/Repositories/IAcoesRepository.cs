
using Api.Domain.Entities;

namespace Api.Repositories;

public interface IAcoesRepository
{
    public void CreateStock(Stock stock);
    public IEnumerable<Stock> ReadStocks();
    public void UpdateStock(Stock stock);
    public void DeleteStock(string id);
}