using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tarea_5.Migrations
{
    /// <inheritdoc />
    public partial class Primera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plataformas",
                columns: table => new
                {
                    PlataformaID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataformas", x => x.PlataformaID);
                });

            migrationBuilder.CreateTable(
                name: "Videojuegos",
                columns: table => new
                {
                    VideojuegosId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Desarrollador = table.Column<string>(type: "TEXT", nullable: false),
                    PlataformaID = table.Column<int>(type: "INTEGER", nullable: false),
                    Genero = table.Column<string>(type: "TEXT", nullable: false),
                    Fecha_Lanzamiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Imagen_Portada = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videojuegos", x => x.VideojuegosId);
                    table.ForeignKey(
                        name: "FK_Videojuegos_Plataformas_PlataformaID",
                        column: x => x.PlataformaID,
                        principalTable: "Plataformas",
                        principalColumn: "PlataformaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    Personajes_VideojuegosId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Alias = table.Column<string>(type: "TEXT", nullable: false),
                    Rol = table.Column<string>(type: "TEXT", nullable: false),
                    Habilidad_Especial = table.Column<string>(type: "TEXT", nullable: false),
                    Arma_Favorita = table.Column<string>(type: "TEXT", nullable: false),
                    Nivel_Poder = table.Column<int>(type: "INTEGER", nullable: false),
                    Imagen_Personaje = table.Column<string>(type: "TEXT", nullable: false),
                    VideojuegoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.Personajes_VideojuegosId);
                    table.ForeignKey(
                        name: "FK_Personajes_Videojuegos_VideojuegoId",
                        column: x => x.VideojuegoId,
                        principalTable: "Videojuegos",
                        principalColumn: "VideojuegosId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_VideojuegoId",
                table: "Personajes",
                column: "VideojuegoId");

            migrationBuilder.CreateIndex(
                name: "IX_Videojuegos_PlataformaID",
                table: "Videojuegos",
                column: "PlataformaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "Videojuegos");

            migrationBuilder.DropTable(
                name: "Plataformas");
        }
    }
}
