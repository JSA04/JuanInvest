using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acoes",
                columns: table => new
                {
                    AcaoId = table.Column<string>(type: "text", nullable: false),
                    NomeEmpresa = table.Column<string>(type: "text", nullable: true),
                    DividendYield = table.Column<double>(type: "double precision", nullable: false),
                    PrecoLucro = table.Column<double>(type: "double precision", nullable: false),
                    PrecoValorPatrimonial = table.Column<double>(type: "double precision", nullable: false),
                    DividaLiquidaEbtda = table.Column<double>(type: "double precision", nullable: false),
                    MargemLiquida = table.Column<double>(type: "double precision", nullable: false),
                    Roe = table.Column<double>(type: "double precision", nullable: false),
                    CagrLucro = table.Column<double>(type: "double precision", nullable: false),
                    CagrReceitas = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acoes", x => x.AcaoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acoes");
        }
    }
}
