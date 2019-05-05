using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimeAddicts.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animes",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Genres = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Premiere = table.Column<string>(nullable: true),
                    URLs = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animes");
        }
    }
}
