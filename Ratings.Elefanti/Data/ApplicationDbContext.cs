using Microsoft.EntityFrameworkCore;

namespace Ratings.Elefanti.Data;
public class ApplicationDbContext : DbContext { 
    private readonly IConfiguration _configuration;
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

}
