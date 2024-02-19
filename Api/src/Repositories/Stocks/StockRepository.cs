using Api.Domain.Entities;
using Api.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Api.Repositories;

public class StockRepository : IStockRepository
{

    private readonly AppDbContext _infrastructure;

    public StockRepository(AppDbContext infrastructure)
    { 
        _infrastructure ??= infrastructure;
    }
    
    public async Task CreateStock(Stock stock) {
        stock.UltimaAtualizacao = DateTime.Now;
        await _infrastructure.Stocks.AddAsync(stock);
        await _infrastructure.SaveChangesAsync();
    }

    public async Task<IEnumerable<Stock>> ReadStocks(int pageNumber, int pageSize) 
    {
        return await _infrastructure
            .Stocks!.AsNoTracking()
            .OrderBy(s => s.Id)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
    }

    public async Task<Stock?> GetStockById(string id) =>
        await _infrastructure.Stocks.AsNoTracking()
            .FirstOrDefaultAsync(s => s.Id == id);

    public async Task<bool> StockExists(string id) => 
        await GetStockById(id) != null;
    
    public async Task UpdateStock(string id, Stock updatedStock) 
    {
        var stockEntity = await _infrastructure.Stocks!
            .FirstAsync(s => s.Id == id);

        stockEntity.Empresa = updatedStock.Empresa;
        stockEntity.Preco = updatedStock.Preco;
        stockEntity.DividendYield = updatedStock.DividendYield;
        stockEntity.PrecoLucro = updatedStock.PrecoLucro;
        stockEntity.PrecoValorPatrimonial = updatedStock.PrecoValorPatrimonial;
        stockEntity.DividaLiquidaEbitda = updatedStock.DividaLiquidaEbitda;
        stockEntity.MargemLiquida = updatedStock.MargemLiquida;
        stockEntity.Roe = updatedStock.Roe;
        stockEntity.CagrLucro = updatedStock.CagrLucro;
        stockEntity.CagrReceitas = updatedStock.CagrReceitas;
        stockEntity.UltimaAtualizacao = DateTime.UtcNow;

        _infrastructure.Stocks.Update(stockEntity); 
        await _infrastructure.SaveChangesAsync();
    }

    public async Task DeleteStock(string id) =>
        await _infrastructure.Stocks.Where(s => s.Id == id)
            .ExecuteDeleteAsync();
}