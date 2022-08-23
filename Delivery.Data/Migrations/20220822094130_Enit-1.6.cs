using Microsoft.EntityFrameworkCore.Migrations;

namespace Delivery.Data.Migrations
{
    public partial class Enit16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "riderRegistrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiderEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiderPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiderAge = table.Column<int>(type: "int", nullable: false),
                    RiderGender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_riderRegistrations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "riderRegistrations");
        }
    }
}
