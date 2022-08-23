using Microsoft.EntityFrameworkCore.Migrations;

namespace Delivery.Data.Migrations
{
    public partial class Enit13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ResturantType",
                table: "resturants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResturantStatus",
                table: "resturants",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResturantStatus",
                table: "resturants");

            migrationBuilder.AlterColumn<string>(
                name: "ResturantType",
                table: "resturants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
