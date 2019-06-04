using Microsoft.EntityFrameworkCore.Migrations;

namespace Licenta.Migrations
{
    public partial class w : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "pula",
                table: "Cart",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pula",
                table: "Cart");
        }
    }
}
