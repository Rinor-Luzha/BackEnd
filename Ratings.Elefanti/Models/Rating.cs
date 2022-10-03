namespace Ratings.Elefanti.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public User User { get; set; }
        public int RatingNr { get; set; }

    }
}
