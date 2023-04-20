using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bercario.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mae",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Data_Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Mae", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CRM = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Celular = table.Column<int>(type: "int", nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Medico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMedico = table.Column<int>(type: "int", nullable: false),
                    Data_Parto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horario_Parto = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Parto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Id_Medico",
                        column: x => x.IdMedico,
                        principalTable: "Medico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bebe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Nascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Peso_Nascimento = table.Column<decimal>(type: "decimal(4,3)", nullable: false),
                    Altura = table.Column<int>(type: "int", nullable: false),
                    IdMae = table.Column<int>(type: "int", nullable: false),
                    IdParto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Bebe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Id_Mae",
                        column: x => x.IdMae,
                        principalTable: "Mae",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Id_Parto",
                        column: x => x.IdParto,
                        principalTable: "Parto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bebe_IdMae",
                table: "Bebe",
                column: "IdMae");

            migrationBuilder.CreateIndex(
                name: "IX_Bebe_IdParto",
                table: "Bebe",
                column: "IdParto");

            migrationBuilder.CreateIndex(
                name: "IX_Parto_IdMedico",
                table: "Parto",
                column: "IdMedico");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bebe");

            migrationBuilder.DropTable(
                name: "Mae");

            migrationBuilder.DropTable(
                name: "Parto");

            migrationBuilder.DropTable(
                name: "Medico");
        }
    }
}
