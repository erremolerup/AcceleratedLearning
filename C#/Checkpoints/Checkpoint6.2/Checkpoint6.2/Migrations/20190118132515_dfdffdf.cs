using Microsoft.EntityFrameworkCore.Migrations;

namespace Checkpoint6._2.Migrations
{
    public partial class dfdffdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "RavioliOnBoard",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "RavioliOnBoard");
        }
    }
}
