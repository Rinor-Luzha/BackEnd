using Ratings.Elefanti.Models;

namespace Ratings.Elefanti.Data
{
    public class RatingRepository : IRatingRepository
    {

        private readonly ApplicationDbContext _db;
        public RatingRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Rating rating)
        {
            _db.Ratings.Add(rating);
            rating.Id = _db.SaveChanges();
            return true;
        }

        public bool Update(Rating rating)
        {
            _db.Ratings.Update(rating);
            rating.Id = _db.SaveChanges();
            return true;
        }

        public bool Remove(Rating rating)
        {
            _db.Ratings.Remove(rating);
            _db.SaveChanges();
            return true;
        }
        public Rating GetById(int id)
        {
            return _db.Ratings.FirstOrDefault(r => r.Id == id);
        }
    }
}
