using Ratings.Elefanti.Models;

namespace Ratings.Elefanti.Data
{
    public interface IMovieCommentRepository
    {
        bool Create(MovieComment movieComment);
        MovieComment GetById(int id);
        bool Remove(MovieComment movieComment);
        bool Update(MovieComment movieComment);
    }
}