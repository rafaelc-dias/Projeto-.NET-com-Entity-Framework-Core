using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APIControleFrotas.Migrations
{
    public partial class Ajustes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motoristas",
                columns: table => new
                {
                    MotoristaId = table.Column<string>(type: "varchar(50)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false),
                    Cnh = table.Column<string>(type: "varchar(10)", nullable: false),
                    ValidadeCnh = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motoristas", x => x.MotoristaId);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    VeiculoId = table.Column<string>(type: "varchar(50)", nullable: false),
                    Modelo = table.Column<string>(type: "varchar(50)", nullable: true),
                    Placa = table.Column<string>(type: "varchar(20)", nullable: true),
                    Ano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.VeiculoId);
                });

            migrationBuilder.CreateTable(
                name: "MotoristasVeiculos",
                columns: table => new
                {
                    MotoristaId = table.Column<string>(type: "varchar(50)", nullable: false),
                    VeiculoId = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotoristasVeiculos", x => new { x.VeiculoId, x.MotoristaId });
                    table.ForeignKey(
                        name: "FK_MotoristasVeiculos_Motoristas_MotoristaId",
                        column: x => x.MotoristaId,
                        principalTable: "Motoristas",
                        principalColumn: "MotoristaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MotoristasVeiculos_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "VeiculoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MotoristasVeiculos_MotoristaId",
                table: "MotoristasVeiculos",
                column: "MotoristaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MotoristasVeiculos");

            migrationBuilder.DropTable(
                name: "Motoristas");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
