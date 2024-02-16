using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class alterandoAtributos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pvp",
                table: "Stocks",
                newName: "PrecoValorPatrimonial");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Stocks",
                newName: "PrecoLucro");

            migrationBuilder.RenameColumn(
                name: "Pl",
                table: "Stocks",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "NetMargin",
                table: "Stocks",
                newName: "MargemLiquida");

            migrationBuilder.RenameColumn(
                name: "NetDebtEbtida",
                table: "Stocks",
                newName: "DividaLiquidaEbitda");

            migrationBuilder.RenameColumn(
                name: "EnterpriseName",
                table: "Stocks",
                newName: "Empresa");

            migrationBuilder.RenameColumn(
                name: "CagrProfit",
                table: "Stocks",
                newName: "CagrReceitas");

            migrationBuilder.RenameColumn(
                name: "CagrIncome",
                table: "Stocks",
                newName: "CagrLucro");

            migrationBuilder.RenameColumn(
                name: "StockId",
                table: "Stocks",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PrecoValorPatrimonial",
                table: "Stocks",
                newName: "Pvp");

            migrationBuilder.RenameColumn(
                name: "PrecoLucro",
                table: "Stocks",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Stocks",
                newName: "Pl");

            migrationBuilder.RenameColumn(
                name: "MargemLiquida",
                table: "Stocks",
                newName: "NetMargin");

            migrationBuilder.RenameColumn(
                name: "Empresa",
                table: "Stocks",
                newName: "EnterpriseName");

            migrationBuilder.RenameColumn(
                name: "DividaLiquidaEbitda",
                table: "Stocks",
                newName: "NetDebtEbtida");

            migrationBuilder.RenameColumn(
                name: "CagrReceitas",
                table: "Stocks",
                newName: "CagrProfit");

            migrationBuilder.RenameColumn(
                name: "CagrLucro",
                table: "Stocks",
                newName: "CagrIncome");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Stocks",
                newName: "StockId");
        }
    }
}
