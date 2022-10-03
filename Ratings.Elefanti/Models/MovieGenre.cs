namespace Ratings.Elefanti.Models
{
    public class MovieGenre
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public Genre Genre { get; set; }
    }
}
