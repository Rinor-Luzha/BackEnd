using BCrypt.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Ratings.Elefanti.Data;
using Ratings.Elefanti.Dtos;
using Ratings.Elefanti.Helpers;
using Ratings.Elefanti.Models;

namespace Ratings.Elefanti.Controllers
{
    [ApiController]
    [Route("/account")]
    public class AuthController : Controller
    {
        private readonly IUserRepository _repository;

        private readonly JwtService _jwtService;
        public AuthController(IUserRepository UserRepository, JwtService JwtService)
        {
            _repository = UserRepository;
            _jwtService = JwtService;
        }
        [HttpPost("register")]
        public IActionResult Register(RegisterDto Dto)
        {
            User User = new User
            {
                Name = Dto.Name,
                Surname = Dto.Surname,
                Email = Dto.Email,
                BirthDate = Dto.BirthDate,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(Dto.Password)
            };
            bool Created = _repository.Create(User);
            if (Created)
            {
                return Ok(new
                {
                    message = "Success"
                });
            }
            return BadRequest(new { message = "Email Exists" });
        }
        [HttpPost("login")]
        public IActionResult Login(LoginDto Dto)
        {
            User? User = _repository.GetByEmail(Dto.Email);
            if (User == null)
            {
                return BadRequest(new { message = "Invalid Credentials" });
            }
            if (!BCrypt.Net.BCrypt.Verify(Dto.Password, User.PasswordHash))
            {
                return BadRequest(new { message = "Invalid Credentials" });

            }
            var Jwt = _jwtService.Generate(User.Id, User.Email);

            Response.Cookies.Append("jwt", Jwt, new CookieOptions
            {
                HttpOnly = true
            });
            return Ok(new
            {
                message = "Success"
            });
        }
        //Method used to check if user is logged in
        [HttpGet("user")]
        public IActionResult User()
        {
            try
            {
                var Jwt = Request.Cookies["jwt"];
                var Token = _jwtService.Verify(Jwt);
                var UserId = int.Parse(Token.Claims.ToList()[0].Value);
                var User = _repository.GetById(UserId);
                return Ok(User);
            }
            catch (Exception e)
            {
                return Unauthorized();
            }
        }

        [HttpPost("logout")]
        public IActionResult Logout()
        {
            Response.Cookies.Delete("jwt");
            return Ok(new
            {
                message = "Success"
            });
        }
    }
}
