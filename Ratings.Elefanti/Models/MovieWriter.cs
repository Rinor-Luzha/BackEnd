namespace Ratings.Elefanti.Models
{
    public class MovieWriter
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public Person Writer { get; set; }
        public string Credit { get; set; }

    }
}
