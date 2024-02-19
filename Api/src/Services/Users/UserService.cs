using Api.Domain;
using Api.Domain.Entities;
using Api.Domain.Responses;
using Api.Repositories;

namespace Api.Services;

public class UserService : IUserService
{

    private readonly IUserRepository _repository;
    private readonly ILogger<UserService> _logger;

    public UserService(IUserRepository repository, ILogger<UserService> logger)
    {
        _repository ??= repository;
        _logger ??= logger;
    }

    public async Task<IServiceResult> UserLogin(string userOrEmail, string password)
    {
        try
        {
            password = PasswordEncryptService.Encrypt(password);
            var user = await _repository.GetUser(userOrEmail, password);

            if (user == null)
                return new ServiceResult(StatusCodes.Status404NotFound,
                    UserResponses.UserNotFound);

            var token = TokenService.GenerateToken(user);

            return new ServiceResult<dynamic>(200, UserResponses.Connected, new { token = token });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return new ServiceResult(500, UserResponses.ConnectFail);
        }
    }

    public async Task<IServiceResult> UserRegister(string userName, string email, string password)
    {
        try
        {
            bool emailExists = await _repository.UserExists(email);
            bool userExists = await _repository.UserExists(userName);

            if (emailExists)
                return new ServiceResult(StatusCodes.Status400BadRequest,
                    UserResponses.AlreadyExistsWithUserName);

            else if (userExists)
                return new ServiceResult(StatusCodes.Status400BadRequest,
                    UserResponses.AlreadyExistsWithEmail);

            password = PasswordEncryptService.Encrypt(password);

            var user = new User
            {
                UserName = userName,
                Email = email,
                Password = password,
                Role = UserRoles.Costumer
            };

            await _repository.RegisterUser(user);

            return new ServiceResult(StatusCodes.Status200OK,
                UserResponses.Registered);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return new ServiceResult(StatusCodes.Status500InternalServerError,
                UserResponses.RegisterFail);
        }
    }

    public async Task<IServiceResult> ReadUsers(int pageNumber, int pageSize)
    {
        try
        {
            var users = await _repository
                .ReadUsers(pageNumber, pageSize);
            var usersList = users.ToList();

            if (!users.Any())
                if (pageNumber != 1) return new ServiceResult(StatusCodes.Status200OK,
                    UserResponses.ReadFilterNotFound);
                else return new ServiceResult(StatusCodes.Status200OK, UserResponses.ReadDontExistsAny);


            return new ServiceResult<IEnumerable<User>>(StatusCodes.Status200OK, UserResponses.Read , usersList);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return new ServiceResult(StatusCodes.Status500InternalServerError,
                UserResponses.RegisterFail);
        }
    }
}