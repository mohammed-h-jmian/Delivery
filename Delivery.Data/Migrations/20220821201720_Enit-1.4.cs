using Microsoft.EntityFrameworkCore.Migrations;

namespace Delivery.Data.Migrations
{
    public partial class Enit14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_messages_resturants_ResturantID",
                table: "messages");

            migrationBuilder.DropIndex(
                name: "IX_messages_ResturantID",
                table: "messages");

            migrationBuilder.DropColumn(
                name: "ResturantID",
                table: "messages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResturantID",
                table: "messages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_messages_ResturantID",
                table: "messages",
                column: "ResturantID");

            migrationBuilder.AddForeignKey(
                name: "FK_messages_resturants_ResturantID",
                table: "messages",
                column: "ResturantID",
                principalTable: "resturants",
                principalColumn: "ResturantID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
