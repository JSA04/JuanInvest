using Api.Domain;
using Api.Domain.Entities;
using Api.Domain.Responses;
using Api.Repositories;

namespace Api.Services;

public class CostumerService : ICostumerService
{

    private readonly ICostumerRepository _repository;
    private readonly ILogger<CostumerService> _logger;

    public CostumerService(ICostumerRepository repository, ILogger<CostumerService> logger)
    {
        _repository ??= repository;
        _logger ??= logger;
    }

    public async Task<IServiceResult> CostumerLogin(string CostumerOrEmail, string password)
    {
        try
        {
            password = PasswordEncryptService.Encrypt(password);
            var Costumer = await _repository.GetCostumer(CostumerOrEmail, password);

            if (Costumer == null)
                return new ServiceResult(StatusCodes.Status404NotFound,
                    CostumerResponses.CostumerNotFound);

            var token = TokenService.GenerateToken(Costumer);

            return new ServiceResult<dynamic>(200, CostumerResponses.Connected, new { token = token });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return new ServiceResult(500, CostumerResponses.ConnectFail);
        }
    }

    public async Task<IServiceResult> CostumerRegister
        (string id, string cpf, string name, string surname, string email, string password)
    {
        try
        {
            bool emailExists = await _repository.CostumerExists(email);
            bool CostumerExists = await _repository.CostumerExists(name);

            if (emailExists)
                return new ServiceResult(StatusCodes.Status400BadRequest,
                    CostumerResponses.AlreadyExistsWithCostumerName);

            else if (CostumerExists)
                return new ServiceResult(StatusCodes.Status400BadRequest,
                    CostumerResponses.AlreadyExistsWithEmail);

            password = PasswordEncryptService.Encrypt(password);

            var Costumer = new Costumer
            {
                Id = id,
                Cpf = cpf,
                Name = name,
                Surname = surname,
                Email = email,
                Password = password,
                Role = CostumerRoles.Costumer
            };

            await _repository.RegisterCostumer(Costumer);

            return new ServiceResult(StatusCodes.Status200OK,
                CostumerResponses.Registered);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return new ServiceResult(StatusCodes.Status500InternalServerError,
                CostumerResponses.RegisterFail);
        }
    }

    public async Task<IServiceResult> ReadCostumers(int pageNumber, int pageSize)
    {
        try
        {
            var Costumers = await _repository
                .ReadCostumers(pageNumber, pageSize);
            var CostumersList = Costumers.ToList();

            if (!Costumers.Any())
                if (pageNumber != 1) return new ServiceResult(StatusCodes.Status200OK,
                    CostumerResponses.ReadFilterNotFound);
                else return new ServiceResult(StatusCodes.Status200OK, CostumerResponses.ReadDontExistsAny);


            return new ServiceResult<IEnumerable<Costumer>>(StatusCodes.Status200OK, CostumerResponses.Read , CostumersList);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return new ServiceResult(StatusCodes.Status500InternalServerError,
                CostumerResponses.RegisterFail);
        }
    }
}