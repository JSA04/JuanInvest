using Api.Domain.Entities;
using Api.Infrastructure;

namespace Api.Repositories;

public class AcoesRepository : IAcoesRepository
{

    private readonly AppDbContext _infrastructure;

    public AcoesRepository(AppDbContext context)
    {
        _infrastructure = context;
    }
    
    public void CreateStock(Stock stock)
    {
        _infrastructure.Stocks!.Add(stock);
        _infrastructure.SaveChanges();
    }

    public IEnumerable<Stock> ReadStocks() => _infrastructure.Stocks!.ToList();

    public void UpdateStock(Stock stock)
    {
        _infrastructure.Stocks!.Update(stock);
        _infrastructure.SaveChanges();
    }

    public void DeleteStock(string id)
    {
        var acao = _infrastructure.Stocks!.Find(id);
        _infrastructure.Stocks.Remove(acao!);
    }
}