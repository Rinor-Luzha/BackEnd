using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ratings.Elefanti.Migrations
{
    /// <inheritdoc />
    public partial class AddImageColumnToMoviesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Movies");
        }
    }
}
