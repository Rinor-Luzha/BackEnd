using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ratings.Elefanti.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Movies
            migrationBuilder.Sql("INSERT INTO Movies(Title,Description,Length,ReleaseDate,Img) VALUES" +
                "('The Shawshank Redemption','Andy Dufresne (Tim Robbins) is sentenced to two consecutive life terms in prison for the murders of his wife and her lover and is sentenced to a tough prison. However, only Andy knows he didnt commit the crimes. While there, he forms a friendship with Red (Morgan Freeman), experiences brutality of prison life, adapts, helps the warden, etc., all in 19 years.'," +
                "'2h 22m','1994-09-22','./img/shawshank.jpg')");


            // Users...
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
