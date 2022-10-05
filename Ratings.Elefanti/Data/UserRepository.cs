using Ratings.Elefanti.Models;

namespace Ratings.Elefanti.Data
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(User user)
        {
            if (_db.Users.FirstOrDefault(u => u.Email == user.Email) != null)
            {
                return false;
            }
            _db.Users.Add(user);
            user.Id = _db.SaveChanges();
            return true;
        }
        public User GetByEmail(string email)
        {
            return _db.Users.FirstOrDefault(u => u.Email == email);
        }
        public User GetById(int id)
        {
            return _db.Users.FirstOrDefault(u => u.Id == id);
        }
    }
}
