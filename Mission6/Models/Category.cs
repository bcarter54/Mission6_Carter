using System.ComponentModel.DataAnnotations;

namespace Mission6.Models;

public class Category
{
    /* Establish Category table */
    [Key]
    [Required]
    public int CategoryId { get; set; }
    [Required]
    public string CategoryName { get; set; }
}