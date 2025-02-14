using Microsoft.EntityFrameworkCore;

namespace Mission6.Models;

public class DbMovieContext : DbContext
{
    /* Create a context to facilitate passing of record info */
    public DbMovieContext(DbContextOptions<DbMovieContext> options) : base(options)
    {
        
    }
    
    /* Use Movie model for the info that will go into the table */
    public DbSet<Movie> Movies { get; set; }
}