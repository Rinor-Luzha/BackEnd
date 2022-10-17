using Ratings.Elefanti.Models;

namespace Ratings.Elefanti.Data
{
    public interface IUserRepository
    {
        bool Create(User user);
        User GetByEmail(string email);
        User GetById(int id);
    }
}