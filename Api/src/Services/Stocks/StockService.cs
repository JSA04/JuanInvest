using Api.Domain;
using Api.Domain.DTOs;
using Api.Domain.Responses;
using Api.Repositories;
using Api.Services.Mappings;

namespace Api.Services;

public class StockService: IStockService
{
    private readonly IStockRepository _repository;
    private readonly ILogger<StockService> _logger;
    
    public StockService(IStockRepository repository, ILogger<StockService> logger)
    {
        _repository ??= repository;
        _logger ??= logger;
    }

    // Método de registro de ações.
    public async Task<IServiceResult> RegisterStock(StockDTO stockDto)
    {
        try
        {
            stockDto.Id = stockDto.Id!.ToUpper();
            
            if (_repository.StockExists(stockDto.Id))
                return new ServiceResult(400, StockResponse.CreateAlreadyExistsWithCode);

            var stockEntity = StockMapper.ToEntity(stockDto);

            await _repository.CreateStock(stockEntity);

            return new ServiceResult<StockDTO>(201, StockResponse.Created, stockDto);
        } 
        catch (Exception ex) 
        {
            _logger.LogError(ex.StackTrace);
            return new ServiceResult(500, StockResponse.CreateFail);
        }
    }
    
    // Método de consulta de todas as ações.
    public async Task<IServiceResult> Stocks(int pageNumber, int pageSize)
    {
        try
        {
            var stocks = await _repository
                .ReadStocks(pageNumber, pageSize);
            var stocksList = stocks.ToList();
            
            if (!stocksList.Any())
                if (pageNumber != 1) return new ServiceResult(200, StockResponse.ReadFilterNotFound);
                else return new ServiceResult(200, StockResponse.ReadDontExistsAny);
            
            var stocksDtoList = StockMapper.ToDtoList(stocksList);

            return new ServiceResult<IEnumerable<StockDTO>>(200, StockResponse.Read, stocksDtoList);
        } 
        catch (Exception ex) 
        {
            _logger.LogError(ex.StackTrace);
            return new ServiceResult(500, StockResponse.ReadFail);
        } 
    } 

    // Método de consulta de ação pelo código.
    public async Task<IServiceResult> GetStockById(string id)
    {     
        try 
        {
            id = id.ToUpper();
            
            var stock = await _repository.GetStockById(id);

            if (stock is null) 
                return new ServiceResult(404, StockResponse.ReadDontExistsWithCode);

            var stockDto = StockMapper.ToDto(stock);

            return new ServiceResult<StockDTO>(200, StockResponse.Read, stockDto);
        } 
        catch (Exception ex) 
        {
            _logger.LogError(ex.StackTrace);
            return new ServiceResult(500, StockResponse.ReadFail);
        }
    } 

    // Método de alteração de ação por Código.
    public async Task<IServiceResult> AlterStock(string id, StockDTO stockDto)
    {
        try 
        {
            id = id.ToUpper();

            if (id != stockDto.Id)
                return new ServiceResult(400, StockResponse.ReadFail);
            
            if (!_repository.StockExists(id))
                return new ServiceResult(400, StockResponse.AlterDifferentBodyId);

            var stock = StockMapper.ToEntity(stockDto);

            await _repository.UpdateStock(id, stock);

            return new ServiceResult(200, StockResponse.Altered);
        } 
        catch (Exception ex) 
        {
            _logger.LogError(ex.StackTrace);
            return new ServiceResult(500, StockResponse.AlterFail);
        }
    }

    // Método de remoção de ação por Código.
    public async Task<IServiceResult> DeleteStock(string id) 
    {
        try
        {
            id = id.ToUpper();

            if (!_repository.StockExists(id))
                return new ServiceResult(400, StockResponse.DeleteDontExists);

            await _repository.DeleteStock(id);
            
            return new ServiceResult(200, StockResponse.Deleted);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return new ServiceResult(500, StockResponse.DeleteFail);
        }
    }
}