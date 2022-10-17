using Ratings.Elefanti.Models;

namespace Ratings.Elefanti.Data
{
    public interface IMovieRepository
    {
        bool Create(Movie movie);
        Movie GetById(int id);
    }
}