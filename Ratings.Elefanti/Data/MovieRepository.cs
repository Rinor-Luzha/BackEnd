using Ratings.Elefanti.Models;

namespace Ratings.Elefanti.Data
{
    public class MovieRepository : IMovieRepository
    {
        private readonly ApplicationDbContext _db;
        public MovieRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Movie movie)
        {
            _db.Movies.Add(movie);
            movie.Id = _db.SaveChanges();
            return true;
        }
        public Movie GetById(int id)
        {
            return _db.Movies.FirstOrDefault(m => m.Id == id);
        }
    }
}
