
using Api.Domain.Responses;
using Api.Services;
using Api.Controllers.Params;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Api.Controllers.Routes;
using Microsoft.OpenApi.Expressions;

namespace Api.Controllers;

[Controller]
[Route("user")]
public class UserController : ControllerBase
{
    private readonly IUserService _service;
    private readonly ILogger _logger;

    public UserController(IUserService service, ILogger<UserController> logger)
    {
        _service ??= service;
        _logger ??= logger;
    }

    [AllowAnonymous]
    [HttpPost(UserRoutes.Login)] 
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Login(
        [FromBody] LoginUserBodyParams bodyParams)
    {
        try 
        {
            string userOrEmail = bodyParams.UserOrEmail;
            string password = bodyParams.Password;

            var result = await _service.UserLogin(userOrEmail, password);
            return StatusCode(result.StatusCode, result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(UserResponses.BadRequest);
        }
    }

    [AllowAnonymous]
    [HttpPost(UserRoutes.Register)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Register(
        [FromBody] RegisterUserBodyParams bodyParams)
    {
        try
        {
            string user = bodyParams.UserName;
            string email = bodyParams.Email;
            string password = bodyParams.Password;

            var result = await _service.UserRegister(user, email, password);

            return StatusCode(result.StatusCode, result);
        } 
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(UserResponses.BadRequest);
        } 
    }

    [AllowAnonymous]
    [HttpPost(UserRoutes.GetAll)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Users(
        int pageNumber = 1, int pageSize = 10)
    {
        try
        {
            var result = await _service.ReadUsers(pageNumber, pageSize);

            return StatusCode(result.StatusCode, result);
        } 
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(UserResponses.BadRequest);
        } 
    }
}