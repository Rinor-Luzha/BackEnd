using Microsoft.EntityFrameworkCore;
using Ratings.Elefanti.Models;

namespace Ratings.Elefanti.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Genre> Genres { get; set; }
        DbSet<MovieActor> MovieActors { get; set; }
        DbSet<MovieComment> MovieComments { get; set; }
        DbSet<MovieDirector> MovieDirectors { get; set; }
        DbSet<MovieGenre> MovieGenres { get; set; }
        DbSet<Movie> Movies { get; set; }
        DbSet<MovieWriter> MovieWriters { get; set; }
        DbSet<Person> People { get; set; }
        DbSet<Rating> Ratings { get; set; }
        DbSet<User> Users { get; set; }
    }
}