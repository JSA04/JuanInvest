using Api.Domain.DTOs;
using Api.Domain.Entities;

namespace Api.Services.Mappings;

public static class StockMapper 
{
    public static Stock ToEntity(StockDTO stockDto) {
        return new Stock
        {
            Id = stockDto.Id,
            Empresa = stockDto.Empresa,
            Preco = stockDto.Preco,
            DividendYield = stockDto.DividendYield,
            PrecoLucro = stockDto.PrecoLucro,
            PrecoValorPatrimonial = stockDto.PrecoValorPatrimonial,
            DividaLiquidaEbitda = stockDto.DividaLiquidaEbitda,
            MargemLiquida = stockDto.MargemLiquida,
            Roe = stockDto.Roe,
            CagrLucro = stockDto.CagrLucro,
            CagrReceitas = stockDto.CagrReceitas,
        };
    }

    public static StockDTO ToDto(Stock stock)
    {
        return new StockDTO
        {
            Id = stock.Id,
            Empresa = stock.Empresa,
            Preco = stock.Preco,
            DividendYield = stock.DividendYield,
            PrecoLucro = stock.PrecoLucro,
            PrecoValorPatrimonial = stock.PrecoValorPatrimonial,
            DividaLiquidaEbitda = stock.DividaLiquidaEbitda,
            MargemLiquida = stock.MargemLiquida,
            Roe = stock.Roe,
            CagrLucro = stock.CagrLucro,
            CagrReceitas = stock.CagrReceitas,
        };
    }
    
    public static IEnumerable<StockDTO> ToDtoList(IEnumerable<Stock> stockList)
    {
        var dtoList = new List<StockDTO>();

        foreach (var stock in stockList)
        {
            var stockDto = ToDto(stock);
            dtoList.Add(stockDto);
        }

        return dtoList;
    }
    

}