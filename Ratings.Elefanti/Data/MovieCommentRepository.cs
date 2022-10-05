using Ratings.Elefanti.Models;

namespace Ratings.Elefanti.Data
{
    public class MovieCommentRepository
    {
        private readonly ApplicationDbContext _db;
        public MovieCommentRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(MovieComment movieComment)
        {
            _db.MovieComments.Add(movieComment);
            movieComment.Id = _db.SaveChanges();
            return true;
        }

        public bool Update(MovieComment movieComment)
        {
            _db.MovieComments.Update(movieComment);
            movieComment.Id = _db.SaveChanges();
            return true;
        }

        public bool Remove(MovieComment movieComment)
        {
            _db.MovieComments.Remove(movieComment);
            _db.SaveChanges();
            return true;
        }
        public MovieComment GetById(int id)
        {
            return _db.MovieComments.FirstOrDefault(m => m.Id == id);
        }
    }
}
