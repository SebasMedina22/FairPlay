using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionTorneoFutbol.Migrations
{
    public partial class FairPlaySeederTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FairPlays_Date",
                table: "FairPlays");

            migrationBuilder.CreateIndex(
                name: "IX_FairPlays_Date_TeamId",
                table: "FairPlays",
                columns: new[] { "Date", "TeamId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_FairPlays_Date_TeamId",
                table: "FairPlays");

            migrationBuilder.CreateIndex(
                name: "IX_FairPlays_Date",
                table: "FairPlays",
                column: "Date",
                unique: true);
        }
    }
}
