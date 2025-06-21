using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvidencePojistencu.Migrations
{
    /// <inheritdoc />
    public partial class Inicializace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pojistenci",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Jmeno = table.Column<string>(type: "TEXT", nullable: false),
                    Prijmeni = table.Column<string>(type: "TEXT", nullable: false),
                    Vek = table.Column<int>(type: "INTEGER", nullable: false),
                    Telefon = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pojistenci", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pojistenci");
        }
    }
}
