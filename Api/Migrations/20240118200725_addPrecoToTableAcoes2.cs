using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class addPrecoToTableAcoes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DividaLiquidaEbtda",
                table: "Acoes",
                newName: "DividaLiquidaEbtida");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DividaLiquidaEbtida",
                table: "Acoes",
                newName: "DividaLiquidaEbtda");
        }
    }
}
