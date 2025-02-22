using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Mission6.Models;

/* Class dedicated to making a space for all of the linked input */
public class Movie
{
    [Key]
    [Required]
    public int MovieId { get; set; }
    [ForeignKey("CategoryId")]
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
    [Required]
    public string Title { get; set; }
    /* Display specific error message if the wrong year value is entered */
    
    [Range(1888, int.MaxValue, ErrorMessage = "Please enter a year later than 1887")]
    [Required]
    public int Year {get; set;}
    public string? Director {get; set;}
    public string? Rating {get; set;}
    [Required]
    public bool Edited {get; set;}
    
    public string? LentTo {get; set;}
    [Required]
    public bool CopiedToPlex {get; set;}
    public string? Notes {get; set;}
}