using Microsoft.EntityFrameworkCore.Migrations;

namespace Delivery.Data.Migrations
{
    public partial class Enit18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerEmail",
                table: "messages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerName",
                table: "messages",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerEmail",
                table: "messages");

            migrationBuilder.DropColumn(
                name: "OwnerName",
                table: "messages");
        }
    }
}
