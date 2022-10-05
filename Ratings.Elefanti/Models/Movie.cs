namespace Ratings.Elefanti.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        //hh:mm:ss
        public string Length { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Img { get; set; }

    }
}
