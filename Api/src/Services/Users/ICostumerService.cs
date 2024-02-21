
namespace Api.Services;

public interface ICostumerService
{
    public Task<IServiceResult> CostumerLogin(string CpfOrEmail, string password);
    public Task<IServiceResult> CostumerRegister(string id, string cpf, string name, string surname, string email, string password);
    public Task<IServiceResult> ReadCostumers(int pageNumber, int pageSize); 
}