using Api.Domain;
using Api.Domain.Responses;
using Api.Repositories;

namespace Api.Services;

public class UserService : IUserService
{

    private readonly IUserRepository _repository;
    private readonly ILogger<UserService> _logger;

    public UserService(IUserRepository repository, ILogger<UserService> logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public async Task<IServiceResult> Login (string userOrEmail, string password)
    {
        try
        {
            var user = await _repository.GetUser(userOrEmail, password);

            if (user == null)
            {
                return new ServiceResult(404, UserResponses.UserNotFound);
            }

            var token = TokenService.GenerateToken(user);

            return new ServiceResult<dynamic>(200, UserResponses.Connected, new {token = token});
        } 
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return new ServiceResult(200, UserResponses.ConnectFail);
        }
    }
}