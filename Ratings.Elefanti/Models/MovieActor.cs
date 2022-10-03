namespace Ratings.Elefanti.Models
{
    public class MovieActor
    {
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public Actor Actor { get; set; }
        public string CharacterName { get; set; }

    }
}
