using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Titles.DB.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    TitleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleName = table.Column<string>(nullable: true),
                    TitleNameSortable = table.Column<string>(nullable: true),
                    TitleTypeId = table.Column<int>(nullable: false),
                    ReleaseYear = table.Column<int>(nullable: false),
                    ProcessedDateTimeUTC = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.TitleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Titles");
        }
    }
}
