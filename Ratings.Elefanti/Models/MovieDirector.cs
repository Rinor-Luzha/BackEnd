namespace Ratings.Elefanti.Models
{
    public class MovieDirector
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public Person Director { get; set; }
    }
}
