// <auto-generated />
using Calculator_Salar_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Calculator_Salar_WebApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211114130545_addColumn")]
    partial class addColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Calculator_Salar_WebApp.Models.GrossSalaryCalculator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Cas")
                        .HasColumnType("bigint");

                    b.Property<long>("Cass")
                        .HasColumnType("bigint");

                    b.Property<long>("GrossSalary")
                        .HasColumnType("bigint");

                    b.Property<long>("NetSalary")
                        .HasColumnType("bigint");

                    b.Property<long>("Tax")
                        .HasColumnType("bigint");

                    b.Property<long>("TaxableBase")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("GrossSalariesCalculator");
                });

            modelBuilder.Entity("Calculator_Salar_WebApp.Models.NetSalaryCalculator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Cas")
                        .HasColumnType("bigint");

                    b.Property<long>("Cass")
                        .HasColumnType("bigint");

                    b.Property<int>("CharityTaxes")
                        .HasColumnType("int");

                    b.Property<long>("GrossSalary")
                        .HasColumnType("bigint");

                    b.Property<long>("NetSalary")
                        .HasColumnType("bigint");

                    b.Property<long>("Tax")
                        .HasColumnType("bigint");

                    b.Property<long>("TaxableBase")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("NetSalariesCalculator");
                });
#pragma warning restore 612, 618
        }
    }
}
