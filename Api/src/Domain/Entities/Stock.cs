
namespace Api.Domain.Entities;

public class Stock
{
    public string? Id {get; set;}    
    public string? Empresa {get; set;}
    public double Preco {get; set;}
    public double DividendYield {get; set;}
    public double PrecoLucro {get; set;}
    public double PrecoValorPatrimonial {get; set;}
    public double DividaLiquidaEbitda {get; set;}
    public double MargemLiquida {get; set;}
    public double Roe {get; set;}
    public double CagrLucro {get; set;}
    public double CagrReceitas {get; set;}
    public DateTime? UltimaAtualizacao {get; set;}
}
