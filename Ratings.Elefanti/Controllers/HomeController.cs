using Microsoft.AspNetCore.Mvc;
using Ratings.Elefanti.Data;
using Ratings.Elefanti.Models;

namespace Ratings.Elefanti.Controllers
{
    [ApiController]
    [Route("/movies")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IUserRepository _userRepository;
        public HomeController(ApplicationDbContext db,IUserRepository UserRepository)
        {
            _db = db;
            _userRepository = UserRepository;
        }
        [HttpGet]
        public IActionResult GetMovies()
        {
            List<Movie> Movies = _db.Movies.ToList<Movie>();
            return Ok(Movies);
        }
    }
}
