using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Mission6.Models;

public class DbMovieContext : DbContext
{
    /* Create a context to facilitate passing of record info */
    public DbMovieContext(DbContextOptions<DbMovieContext> options) : base(options)
    {
        
    }
    
    /* Use Movie model for the info that will go into the table */
    [Required]
    public DbSet<Movie> Movies { get; set; }
    [Required]
    public DbSet<Category> Categories { get; set; }
    
    /* Have the structure of the Category data set */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, CategoryName = "Miscellaneous" },
            new Category { CategoryId = 2, CategoryName = "Drama" },
            new Category { CategoryId = 3, CategoryName = "Television" },
            new Category { CategoryId = 4, CategoryName = "Horror/Suspense" },
            new Category { CategoryId = 5, CategoryName = "Comedy" },
            new Category { CategoryId = 6, CategoryName = "Family" },
            new Category { CategoryId = 7, CategoryName = "Action/Adventure" },
            new Category { CategoryId = 8, CategoryName = "VHS" }
        );
        base.OnModelCreating(modelBuilder);
    }
}