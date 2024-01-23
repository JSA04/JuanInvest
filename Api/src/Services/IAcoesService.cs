using Api.Domain.Entities;

namespace Api.Services;

public interface IAcoesService
{
    public string CreateStock(Stock stock);
    public IEnumerable<Stock>? ReadStocks();
    public string UpdateStock(Stock stock);
    public string DeleteStock(string id);
}