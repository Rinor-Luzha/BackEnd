using Ratings.Elefanti.Models;

namespace Ratings.Elefanti.Data
{
    public interface IRatingRepository
    {
        bool Create(Rating rating);
        Rating GetById(int id);
        bool Remove(Rating rating);
        bool Update(Rating rating);
    }
}