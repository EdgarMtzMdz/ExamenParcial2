using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamenP2.Migrations
{
    /// <inheritdoc />
    public partial class Juguetes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Juguetes",
                columns: table => new
                {
                    idJuguetes = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false),
                    Vigencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juguetes", x => x.idJuguetes);
                });

            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Juguetes");

            
        }
    }
}
