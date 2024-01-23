using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class mudandoPraIngles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acoes");

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    StockId = table.Column<string>(type: "text", nullable: false),
                    EnterpriseName = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    DividendYield = table.Column<double>(type: "double precision", nullable: false),
                    Pl = table.Column<double>(type: "double precision", nullable: false),
                    Pvl = table.Column<double>(type: "double precision", nullable: false),
                    NetDebtEbtida = table.Column<double>(type: "double precision", nullable: false),
                    NetMargin = table.Column<double>(type: "double precision", nullable: false),
                    Roe = table.Column<double>(type: "double precision", nullable: false),
                    CagrProfit = table.Column<double>(type: "double precision", nullable: false),
                    CagrIncome = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.StockId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.CreateTable(
                name: "Acoes",
                columns: table => new
                {
                    AcaoId = table.Column<string>(type: "text", nullable: false),
                    CagrLucro = table.Column<double>(type: "double precision", nullable: false),
                    CagrReceitas = table.Column<double>(type: "double precision", nullable: false),
                    DividaLiquidaEbtida = table.Column<double>(type: "double precision", nullable: false),
                    DividendYield = table.Column<double>(type: "double precision", nullable: false),
                    MargemLiquida = table.Column<double>(type: "double precision", nullable: false),
                    NomeEmpresa = table.Column<string>(type: "text", nullable: true),
                    Preco = table.Column<double>(type: "double precision", nullable: false),
                    PrecoLucro = table.Column<double>(type: "double precision", nullable: false),
                    PrecoValorPatrimonial = table.Column<double>(type: "double precision", nullable: false),
                    Roe = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acoes", x => x.AcaoId);
                });
        }
    }
}
