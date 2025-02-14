using System.ComponentModel.DataAnnotations;

namespace Mission6.Models;

/* Class dedicated to making a space for all of the linked input */
public class Movie
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string Category { get; set; }
    public string Title { get; set; }
    public string Year {get; set;}
    public string Director {get; set;}
    public string Rating {get; set;}
    public string Edited {get; set;}
    public string? Lent {get; set;}
    public string? Notes {get; set;}
}