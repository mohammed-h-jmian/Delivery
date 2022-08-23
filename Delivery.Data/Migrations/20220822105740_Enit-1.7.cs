using Microsoft.EntityFrameworkCore.Migrations;

namespace Delivery.Data.Migrations
{
    public partial class Enit17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "riderRegistrations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hearAboutUs",
                table: "riderRegistrations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "vehicle",
                table: "riderRegistrations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "riderRegistrations");

            migrationBuilder.DropColumn(
                name: "hearAboutUs",
                table: "riderRegistrations");

            migrationBuilder.DropColumn(
                name: "vehicle",
                table: "riderRegistrations");
        }
    }
}
