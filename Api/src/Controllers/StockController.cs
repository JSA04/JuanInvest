using Api.Domain.Entities;
using Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

public class StockController : Controller
{
    private readonly IAcoesService _service;
    
    public StockController(IAcoesService service)
    {
        _service = service;
    }
    
    [HttpPost("CadastrarAcao")]
    public ActionResult CadastrarAcao([FromBody] Stock stock)
    {
        var cadastroRequest = _service.CreateStock(stock);

        return Ok(cadastroRequest);
    }
    
    [HttpGet("Acoes")]
    public ActionResult<IEnumerable<Stock>?> Acoes()
    {
        var acoesRequest = _service.ReadStocks();
        return Ok(acoesRequest);
    } 

    [HttpPatch("AlterarAcao")]
    public ActionResult AlterarAcao([FromBody] Stock stock)
    {
        var alterarRequest = _service.UpdateStock(stock);

        return Ok(alterarRequest);
    }
}