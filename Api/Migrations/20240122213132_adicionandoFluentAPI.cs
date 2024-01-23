using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class adicionandoFluentAPI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pvl",
                table: "Stocks");

            migrationBuilder.AlterColumn<double>(
                name: "Roe",
                table: "Stocks",
                type: "double precision",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Stocks",
                type: "double precision",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Pl",
                table: "Stocks",
                type: "double precision",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<double>(
                name: "NetMargin",
                table: "Stocks",
                type: "double precision",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<double>(
                name: "NetDebtEbtida",
                table: "Stocks",
                type: "double precision",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<double>(
                name: "DividendYield",
                table: "Stocks",
                type: "double precision",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<double>(
                name: "CagrProfit",
                table: "Stocks",
                type: "double precision",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<double>(
                name: "CagrIncome",
                table: "Stocks",
                type: "double precision",
                precision: 10,
                scale: 2,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AddColumn<double>(
                name: "Pvp",
                table: "Stocks",
                type: "double precision",
                precision: 10,
                scale: 2,
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pvp",
                table: "Stocks");

            migrationBuilder.AlterColumn<double>(
                name: "Roe",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<double>(
                name: "Pl",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<double>(
                name: "NetMargin",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<double>(
                name: "NetDebtEbtida",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<double>(
                name: "DividendYield",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<double>(
                name: "CagrProfit",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AlterColumn<double>(
                name: "CagrIncome",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldPrecision: 10,
                oldScale: 2);

            migrationBuilder.AddColumn<double>(
                name: "Pvl",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
