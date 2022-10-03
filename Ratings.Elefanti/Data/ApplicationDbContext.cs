using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Ratings.Elefanti.Models;

namespace Ratings.Elefanti.Data;
public class ApplicationDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<MovieGenre> MovieGenres { get; set; }
    public DbSet<User> Users { get; set; }

    public DbSet<Rating> Ratings { get; set; }
    public DbSet<MovieComment> MovieComments { get; set; }
    public DbSet<Person> People { get; set; }
    public DbSet<MovieActor> MovieActors { get; set; }

    public DbSet<MovieDirector> MovieDirectors { get; set; }

    public DbSet<MovieWriter> MovieWriters { get; set; }
}