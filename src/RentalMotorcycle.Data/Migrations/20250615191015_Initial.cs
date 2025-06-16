using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentalMotorcycle.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "RentalMotorcycle");

            migrationBuilder.CreateTable(
                name: "DeliveryMan",
                schema: "RentalMotorcycle",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar", nullable: false),
                    nome = table.Column<string>(type: "varchar", nullable: false),
                    cnpj = table.Column<string>(type: "varchar", nullable: false),
                    data_nascimento = table.Column<DateTime>(type: "date", nullable: false),
                    cnh = table.Column<string>(type: "varchar", nullable: false),
                    tipo_cnh = table.Column<string>(type: "varchar", nullable: false),
                    imagem_cnh = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryMan", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "motorcycle",
                schema: "RentalMotorcycle",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar", nullable: false),
                    ano = table.Column<int>(type: "integer", nullable: false),
                    modelo = table.Column<string>(type: "varchar", nullable: false),
                    placa = table.Column<string>(type: "varchar", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motorcycle", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rental",
                schema: "RentalMotorcycle",
                columns: table => new
                {
                    id = table.Column<string>(type: "varchar", nullable: false),
                    entregador_id = table.Column<string>(type: "varchar", nullable: false),
                    moto_id = table.Column<string>(type: "varchar", nullable: false),
                    data_inicio = table.Column<DateTime>(type: "date", nullable: false),
                    data_fim = table.Column<DateTime>(type: "date", nullable: false),
                    data_previsao = table.Column<DateTime>(type: "date", nullable: false),
                    data_devolucao = table.Column<DateTime>(type: "date", nullable: false),
                    plano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rental", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DeliveryMan",
                schema: "RentalMotorcycle");

            migrationBuilder.DropTable(
                name: "motorcycle",
                schema: "RentalMotorcycle");

            migrationBuilder.DropTable(
                name: "rental",
                schema: "RentalMotorcycle");
        }
    }
}
