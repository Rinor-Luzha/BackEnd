using Microsoft.EntityFrameworkCore;
using Ratings.Elefanti.Models;

namespace Ratings.Elefanti.Data;
public class ApplicationDbContext : DbContext { 
    private readonly IConfiguration _configuration;
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<User> Users { get; set; }

}
