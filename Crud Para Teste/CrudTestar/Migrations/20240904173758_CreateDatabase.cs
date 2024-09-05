using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudTestar.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    idUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeCompletoUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usuarioUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    senhaUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nascimentoUsuario = table.Column<DateTime>(type: "datetime2", nullable: false),
                    telefoneUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpfUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.idUsuario);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
