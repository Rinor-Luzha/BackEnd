using Ratings.Elefanti.Models;

namespace Ratings.Elefanti.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _db;
        public UserRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(User User)
        {
            if (_db.Users.FirstOrDefault(u => u.Email == User.Email)!=null){
                return false;
            }
            _db.Users.Add(User);
            User.Id = _db.SaveChanges();
            return true;
        }
        public User GetByEmail(string Email)
        {
            return _db.Users.FirstOrDefault(u => u.Email == Email);
        }
        public User GetById(int Id)
        {
            return _db.Users.FirstOrDefault(u => u.Id== Id);
        }
    }
}
