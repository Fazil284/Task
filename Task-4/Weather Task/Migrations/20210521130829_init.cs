using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task4b.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weathers",
                columns: table => new
                {
                    City = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    highTemp = table.Column<double>(type: "float", nullable: false),
                    lowTemp = table.Column<double>(type: "float", nullable: false),
                    forecast = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weathers", x => x.City);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weathers");
        }
    }
}
