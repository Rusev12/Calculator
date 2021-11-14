using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculator_Salar_WebApp.Migrations
{
    public partial class changeToDecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cass",
                table: "NetSalariesCalculator");

            migrationBuilder.DropColumn(
                name: "Tax",
                table: "NetSalariesCalculator");

            migrationBuilder.DropColumn(
                name: "TaxableBase",
                table: "NetSalariesCalculator");

            migrationBuilder.AlterColumn<decimal>(
                name: "NetSalary",
                table: "NetSalariesCalculator",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<decimal>(
                name: "GrossSalary",
                table: "NetSalariesCalculator",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<decimal>(
                name: "CharityTaxes",
                table: "NetSalariesCalculator",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SocialContributions",
                table: "NetSalariesCalculator",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SocialContributions",
                table: "NetSalariesCalculator");

            migrationBuilder.AlterColumn<long>(
                name: "NetSalary",
                table: "NetSalariesCalculator",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<long>(
                name: "GrossSalary",
                table: "NetSalariesCalculator",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "CharityTaxes",
                table: "NetSalariesCalculator",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<long>(
                name: "Cass",
                table: "NetSalariesCalculator",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Tax",
                table: "NetSalariesCalculator",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "TaxableBase",
                table: "NetSalariesCalculator",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
