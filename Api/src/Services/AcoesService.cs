using Api.Domain.Entities;
using Api.Repositories;

namespace Api.Services;

public class AcoesService : IAcoesService
{

    private readonly IAcoesRepository _repository;

    public AcoesService(IAcoesRepository repository)
    {
        _repository = repository;
    }
    
    public string CreateStock(Stock stock)
    {
        try
        {
            _repository.CreateStock(stock);
            return "Ação cadastrada com sucesso."; 
        }
        catch (Exception ex) 
        {
            Console.Write(ex);
            return "Houve uma falha na criação da Ação.";
        }
    }

    public IEnumerable<Stock>? ReadStocks()
    {
        try
        {
            var stocks = _repository.ReadStocks();

            // if (!stocks.Any()) return new ()};
            
            return stocks;
        }
        catch (Exception ex)
        {
            Console.Write(ex);
            return null;
        }
    }

    public string UpdateStock(Stock stock)
    {
        try
        {
            _repository.UpdateStock(stock);
            return "Ação atualizada com sucesso.";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return "Houve um erro na atualização da Ação.";
        }
    }

    public string DeleteStock(string id)
    {
        try
        {
            _repository.DeleteStock(id);
            return "Ação deletado com sucesso.";
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return "Houve um erro na deleção da ação.";
        }
    }
}