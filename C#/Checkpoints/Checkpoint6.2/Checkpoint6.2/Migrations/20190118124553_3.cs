using Microsoft.EntityFrameworkCore.Migrations;

namespace Checkpoint6._2.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "RavioliOnBoard");

            migrationBuilder.AddColumn<int>(
                name: "SpaceshipId",
                table: "RavioliOnBoard",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RavioliOnBoard_SpaceshipId",
                table: "RavioliOnBoard",
                column: "SpaceshipId");

            migrationBuilder.AddForeignKey(
                name: "FK_RavioliOnBoard_Spaceships_SpaceshipId",
                table: "RavioliOnBoard",
                column: "SpaceshipId",
                principalTable: "Spaceships",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RavioliOnBoard_Spaceships_SpaceshipId",
                table: "RavioliOnBoard");

            migrationBuilder.DropIndex(
                name: "IX_RavioliOnBoard_SpaceshipId",
                table: "RavioliOnBoard");

            migrationBuilder.DropColumn(
                name: "SpaceshipId",
                table: "RavioliOnBoard");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "RavioliOnBoard",
                nullable: true);
        }
    }
}
