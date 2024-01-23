using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class aplicandoDataNotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Roe",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<double>(
                name: "Pvl",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<double>(
                name: "Pl",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<double>(
                name: "NetMargin",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<double>(
                name: "NetDebtEbtida",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<string>(
                name: "EnterpriseName",
                table: "Stocks",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "DividendYield",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<double>(
                name: "CagrProfit",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<double>(
                name: "CagrIncome",
                table: "Stocks",
                type: "numeric(10,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<string>(
                name: "StockId",
                table: "Stocks",
                type: "character varying(6)",
                maxLength: 6,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Roe",
                table: "Stocks",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Pvl",
                table: "Stocks",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Stocks",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<double>(
                name: "Pl",
                table: "Stocks",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<double>(
                name: "NetMargin",
                table: "Stocks",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<double>(
                name: "NetDebtEbtida",
                table: "Stocks",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<string>(
                name: "EnterpriseName",
                table: "Stocks",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<double>(
                name: "DividendYield",
                table: "Stocks",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<double>(
                name: "CagrProfit",
                table: "Stocks",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<double>(
                name: "CagrIncome",
                table: "Stocks",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "numeric(10,2)");

            migrationBuilder.AlterColumn<string>(
                name: "StockId",
                table: "Stocks",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(6)",
                oldMaxLength: 6);
        }
    }
}
