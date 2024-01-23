
namespace Api.Domain.Entities;

public class Stock 
{
    public string? StockId {get; set;}    
    public string? EnterpriseName {get; set;}
    public double Price {get; set;}
    public double DividendYield {get; set;}
    public double Pl {get; set;}
    public double Pvp {get; set;}
    public double NetDebtEbtida {get; set;}
    public double NetMargin {get; set;}
    public double Roe {get; set;}
    public double CagrProfit {get; set;}
    public double CagrIncome {get; set;}
}
