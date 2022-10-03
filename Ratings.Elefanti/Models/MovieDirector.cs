namespace Ratings.Elefanti.Models
{
    public class MovieDirector
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public Director Director { get; set; }
    }
}
