namespace Ratings.Elefanti.Models
{
    public class MovieComment
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public User User { get; set; }
        public string Comment { get; set; }

    }
}
