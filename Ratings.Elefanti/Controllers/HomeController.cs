using Microsoft.AspNetCore.Mvc;

namespace Ratings.Elefanti.Controllers
{
    [ApiController]
    [Route("/api")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
