using Api.Domain;
using Api.Domain.DTOs;

namespace Api.Services;

public interface IStockService
{
    public Task<IServiceResult> RegisterStock(StockDTO stockDto);
    public Task<IServiceResult> Stocks(int pageNumber, int pageSize);
    public Task<IServiceResult> GetStockById(string id);
    public Task<IServiceResult> AlterStock(string id, StockDTO stockDto);
    public Task<IServiceResult> DeleteStock(string id);
}