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
    [Route("/api/account")]
    public class AuthController : Controller
    {
        private readonly UserRepository _repository;

        private readonly JwtService _jwtService;
        public AuthController(UserRepository UserRepository, JwtService JwtService)
        {
            _repository = UserRepository;
            _jwtService = JwtService;
        }
        [HttpPost("register")]
        public IActionResult Register(RegisterDto dto)
        {
            if (dto.Name.Length <= 2)
            {
                return BadRequest(new { message = "The name has to be 3 characters or more" });
            }

            if (dto.Surname.Length <= 2)
            {
                return BadRequest(new { message = "The surname has to be 3 characters or more" });
            }

            if (!dto.Email.Contains("@"))
            {
                return BadRequest(new { message = "The email needs to have an @" });
            }

            if (dto.Password.Length < 6)
            {
                return BadRequest(new { message = "The password has to be at least 6 characters long" });
            }

            if (!dto.Password.Any(n => char.IsDigit(n)))
            {
                return BadRequest(new { message = "The password needs to have at least one number" });
            }


            User user = new User
            {
                Name = dto.Name,
                Surname = dto.Surname,
                Email = dto.Email,
                BirthDate = dto.BirthDate,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password)
            };
            bool created = _repository.Create(user);
            if (created)
            {
                return Created("Success",user);
            }
            return BadRequest(new { message = "Email Exists" });
        }
        [HttpPost("login")]
        public IActionResult Login(LoginDto dto)
        {
            User? user = _repository.GetByEmail(dto.Email);
            if (user == null)
            {
                return BadRequest(new { message = "Invalid Credentials" });
            }
            if (!BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash))
            {
                return BadRequest(new { message = "Invalid Credentials" });

            }
            var jwt = _jwtService.Generate(user.Id, user.Email);

            Response.Cookies.Append("jwt", jwt, new CookieOptions
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
                var jwt = Request.Cookies["jwt"];
                var token = _jwtService.Verify(jwt);
                var userId = int.Parse(token.Claims.ToList()[0].Value);
                var user = _repository.GetById(userId);
                return Ok(user);
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
            return NoContent();
        }
    }
}
