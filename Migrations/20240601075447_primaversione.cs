using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cau.Federico._5h.ECommerce.Migrations
{
    /// <inheritdoc />
    public partial class primaversione : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Maglie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Squadra = table.Column<string>(type: "TEXT", nullable: true),
                    Tipologia = table.Column<string>(type: "TEXT", nullable: true),
                    Taglia = table.Column<string>(type: "TEXT", nullable: true),
                    Prezzo = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maglie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Utenti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Datanascita = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    NomeUtente = table.Column<string>(type: "TEXT", nullable: true),
                    Psw = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utenti", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maglie");

            migrationBuilder.DropTable(
                name: "Utenti");
        }
    }
}
