using Ratings.Elefanti.Models;

namespace Ratings.Elefanti.Data
{
    public interface IUserRepository
    {
        bool Create(User User);
        User GetByEmail(string Email);
        User GetById(int Id);
    }
}
