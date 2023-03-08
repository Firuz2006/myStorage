using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Otchet.DataBase.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Desk",
                table: "CashOuts",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Banks",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desk",
                table: "CashOuts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Banks");
        }
    }
}
