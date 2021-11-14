using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculator_Salar_WebApp.Migrations
{
    public partial class InitialMigrationVersion10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalculatorSalariiBrute");

            migrationBuilder.DropTable(
                name: "CalculatorSalariiNete");

            migrationBuilder.CreateTable(
                name: "GrossSalariesCalculator",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GrossSalary = table.Column<long>(nullable: false),
                    Cas = table.Column<long>(nullable: false),
                    Cass = table.Column<long>(nullable: false),
                    TaxableBase = table.Column<long>(nullable: false),
                    Tax = table.Column<long>(nullable: false),
                    NetSalary = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GrossSalariesCalculator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NetSalariesCalculator",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GrossSalary = table.Column<long>(nullable: false),
                    Cas = table.Column<long>(nullable: false),
                    Cass = table.Column<long>(nullable: false),
                    TaxableBase = table.Column<long>(nullable: false),
                    Tax = table.Column<long>(nullable: false),
                    NetSalary = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NetSalariesCalculator", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GrossSalariesCalculator");

            migrationBuilder.DropTable(
                name: "NetSalariesCalculator");

            migrationBuilder.CreateTable(
                name: "CalculatorSalariiBrute",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BazaImpozabila = table.Column<long>(nullable: false),
                    Cas = table.Column<long>(nullable: false),
                    Cass = table.Column<long>(nullable: false),
                    Impozit = table.Column<long>(nullable: false),
                    SalarBrut = table.Column<long>(nullable: false),
                    SalarNet = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculatorSalariiBrute", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CalculatorSalariiNete",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BazaImpozabila = table.Column<long>(nullable: false),
                    Cas = table.Column<long>(nullable: false),
                    Cass = table.Column<long>(nullable: false),
                    Impozit = table.Column<long>(nullable: false),
                    SalarBrut = table.Column<long>(nullable: false),
                    SalarNet = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculatorSalariiNete", x => x.Id);
                });
        }
    }
}
