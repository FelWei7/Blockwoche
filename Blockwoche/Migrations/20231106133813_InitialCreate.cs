using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blockwoche.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lehrer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lehrer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schueler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schueler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuchLehrer",
                columns: table => new
                {
                    BuecherId = table.Column<int>(type: "int", nullable: false),
                    LehrerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuchLehrer", x => new { x.BuecherId, x.LehrerId });
                    table.ForeignKey(
                        name: "FK_BuchLehrer_Buch_BuecherId",
                        column: x => x.BuecherId,
                        principalTable: "Buch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuchLehrer_Lehrer_LehrerId",
                        column: x => x.LehrerId,
                        principalTable: "Lehrer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BuchSchueler",
                columns: table => new
                {
                    BuchId = table.Column<int>(type: "int", nullable: false),
                    SchuelerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuchSchueler", x => new { x.BuchId, x.SchuelerId });
                    table.ForeignKey(
                        name: "FK_BuchSchueler_Buch_BuchId",
                        column: x => x.BuchId,
                        principalTable: "Buch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuchSchueler_Schueler_SchuelerId",
                        column: x => x.SchuelerId,
                        principalTable: "Schueler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchuelerBuch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchuelerId = table.Column<int>(type: "int", nullable: false),
                    BuchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchuelerBuch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchuelerBuch_Buch_BuchId",
                        column: x => x.BuchId,
                        principalTable: "Buch",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchuelerBuch_Schueler_SchuelerId",
                        column: x => x.SchuelerId,
                        principalTable: "Schueler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuchLehrer_LehrerId",
                table: "BuchLehrer",
                column: "LehrerId");

            migrationBuilder.CreateIndex(
                name: "IX_BuchSchueler_SchuelerId",
                table: "BuchSchueler",
                column: "SchuelerId");

            migrationBuilder.CreateIndex(
                name: "IX_SchuelerBuch_BuchId",
                table: "SchuelerBuch",
                column: "BuchId");

            migrationBuilder.CreateIndex(
                name: "IX_SchuelerBuch_SchuelerId",
                table: "SchuelerBuch",
                column: "SchuelerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuchLehrer");

            migrationBuilder.DropTable(
                name: "BuchSchueler");

            migrationBuilder.DropTable(
                name: "SchuelerBuch");

            migrationBuilder.DropTable(
                name: "Lehrer");

            migrationBuilder.DropTable(
                name: "Buch");

            migrationBuilder.DropTable(
                name: "Schueler");
        }
    }
}
