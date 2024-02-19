using Api.Controllers.Routes;
using Api.Domain;
using Api.Domain.DTOs;
using Api.Domain.Responses;
using Api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Controller]
[Route("stock")]
public class StockController : ControllerBase
{
    private readonly IStockService _service;
    private readonly ILogger<StockController> _logger;

    public StockController(IStockService service, ILogger<StockController> logger)
    {
        _service ??= service;
        _logger ??= logger;
    }

    [HttpPost(StockRoutes.Register)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [Authorize(Roles = UserRoles.Costumer)]
    public async Task<IActionResult> RegisterStock([FromBody] StockDTO stockDto)
    {
        try
        {
            var result = await _service.RegisterStock(stockDto);
            return StatusCode(result.StatusCode, result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(StockResponse.BadRequest); 
        }
    }

    [HttpGet(StockRoutes.GetAll)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [Authorize(Roles = $"{UserRoles.Costumer},{UserRoles.System}")]
    public async Task<IActionResult> Stocks
        ([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
    {
        try
        {
            var result = await _service.Stocks(pageNumber, pageSize);
            return StatusCode(result.StatusCode, result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(StockResponse.BadRequest); 
        }
    }

    [HttpGet(StockRoutes.GetById)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [Authorize(Roles = $"{UserRoles.Costumer},{UserRoles.System}")]
    public async Task<IActionResult> GetStockById ([FromRoute] string id)
    {
        try
        {
            var result = await _service.GetStockById(id);
            return StatusCode(result.StatusCode, result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(StockResponse.BadRequest); 
        }
    }

    [HttpPut(StockRoutes.Alter)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [Authorize(Roles = UserRoles.System)]
    public async Task<IActionResult> AlterStock
        ([FromRoute] string id, [FromBody] StockDTO stockDto)
    {
        try 
        {
            var result = await _service.AlterStock(id, stockDto);
            return StatusCode(result.StatusCode, result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(StockResponse.BadRequest); 
        }
    }

    [HttpDelete(StockRoutes.Delete)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [Authorize(Roles = UserRoles.System)]
    public async Task<IActionResult> DeleteStock([FromRoute] string id)
    {
        try 
        {
            var result = await _service.DeleteStock(id);
            return StatusCode(result.StatusCode, result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.StackTrace);
            return BadRequest(StockResponse.BadRequest);        
        }   
    }
}