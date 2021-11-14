using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculator_Salar_WebApp.Migrations
{
    public partial class RenameDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CalculatorSalariuNet",
                table: "CalculatorSalariuNet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CalculatorSalariuBrut",
                table: "CalculatorSalariuBrut");

            migrationBuilder.RenameTable(
                name: "CalculatorSalariuNet",
                newName: "CalculatorSalariiNete");

            migrationBuilder.RenameTable(
                name: "CalculatorSalariuBrut",
                newName: "CalculatorSalariiBrute");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CalculatorSalariiNete",
                table: "CalculatorSalariiNete",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CalculatorSalariiBrute",
                table: "CalculatorSalariiBrute",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CalculatorSalariiNete",
                table: "CalculatorSalariiNete");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CalculatorSalariiBrute",
                table: "CalculatorSalariiBrute");

            migrationBuilder.RenameTable(
                name: "CalculatorSalariiNete",
                newName: "CalculatorSalariuNet");

            migrationBuilder.RenameTable(
                name: "CalculatorSalariiBrute",
                newName: "CalculatorSalariuBrut");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CalculatorSalariuNet",
                table: "CalculatorSalariuNet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CalculatorSalariuBrut",
                table: "CalculatorSalariuBrut",
                column: "Id");
        }
    }
}
