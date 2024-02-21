
using Api.Domain.Responses;
using Api.Services;
using Api.Controllers.Params;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Api.Controllers.Routes;

namespace Api.Controllers;

[Controller]
[Route("costumer")]
public class CostumerController : ControllerBase
{
    private readonly ICostumerService _service;
    private readonly ILogger _logger;

    public CostumerController(ICostumerService service, ILogger<CostumerController> logger)
    {
        _service ??= service;
        _logger ??= logger;
    }

    [AllowAnonymous]
    [HttpPost(CostumerRoutes.Login)] 
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Login(
        [FromBody] LoginCostumerParams bodyParams)
    {
        try 
        {
            string cpfOrEmail = bodyParams.CpfOrEmail;
            string password = bodyParams.Password;

            var result = await _service.CostumerLogin(cpfOrEmail, password);
            return StatusCode(result.StatusCode, result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(CostumerResponses.BadRequest);
        }
    }

    [AllowAnonymous]
    [HttpPost(CostumerRoutes.Register)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Register(
        [FromBody] RegisterCostumerParams bodyParams)
    {
        try
        {
            string id = Guid.NewGuid().ToString();
            string cpf = bodyParams.Cpf;
            string surname = bodyParams.Surname;
            string name = bodyParams.Name;
            string email = bodyParams.Email;
            string password = bodyParams.Password;

            var result = await _service.CostumerRegister(id, cpf, name, surname, email, password);

            return StatusCode(result.StatusCode, result);
        } 
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(CostumerResponses.BadRequest);
        } 
    }

    [AllowAnonymous]
    [HttpPost(CostumerRoutes.GetAll)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Costumers(
        int pageNumber = 1, int pageSize = 10)
    {
        try
        {
            var result = await _service.ReadCostumers(pageNumber, pageSize);

            return StatusCode(result.StatusCode, result);
        } 
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(CostumerResponses.BadRequest);
        } 
    }
}