using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BrainBox.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedCustomPlayerIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalMatchesPlayed",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalMatchesWon",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalMatchesPlayed",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TotalMatchesWon",
                table: "AspNetUsers");
        }
    }
}
