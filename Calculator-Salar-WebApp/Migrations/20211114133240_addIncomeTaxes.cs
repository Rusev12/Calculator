using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculator_Salar_WebApp.Migrations
{
    public partial class addIncomeTaxes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cas",
                table: "NetSalariesCalculator");

            migrationBuilder.AlterColumn<int>(
                name: "CharityTaxes",
                table: "NetSalariesCalculator",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "IncomeTax",
                table: "NetSalariesCalculator",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IncomeTax",
                table: "NetSalariesCalculator");

            migrationBuilder.AlterColumn<int>(
                name: "CharityTaxes",
                table: "NetSalariesCalculator",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Cas",
                table: "NetSalariesCalculator",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
