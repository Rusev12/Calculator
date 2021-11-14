using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculator_Salar_WebApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CalculatorSalariuBrut",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SalarBrut = table.Column<long>(nullable: false),
                    Cas = table.Column<long>(nullable: false),
                    Cass = table.Column<long>(nullable: false),
                    BazaImpozabila = table.Column<long>(nullable: false),
                    Impozit = table.Column<long>(nullable: false),
                    SalarNet = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculatorSalariuBrut", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CalculatorSalariuNet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SalarBrut = table.Column<long>(nullable: false),
                    Cas = table.Column<long>(nullable: false),
                    Cass = table.Column<long>(nullable: false),
                    BazaImpozabila = table.Column<long>(nullable: false),
                    Impozit = table.Column<long>(nullable: false),
                    SalarNet = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalculatorSalariuNet", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CalculatorSalariuBrut");

            migrationBuilder.DropTable(
                name: "CalculatorSalariuNet");
        }
    }
}
