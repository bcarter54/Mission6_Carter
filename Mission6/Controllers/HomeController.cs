using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6.Models;

namespace Mission6.Controllers;

public class HomeController : Controller
{
    /* Create a variable that can be used to hold the database table information*/
    private DbMovieContext _context;
    
    /* Add in the table information to context */
    public HomeController(DbMovieContext context)
    {
        _context = context;
    }

    /* Show index page*/
    public IActionResult Index()
    {
        return View();
    }

    /* Show the get to know joel page*/
    public IActionResult GetToKnow()
    {
        return View("GetToKnowJoel");
    }

    /* When AddMovie is called, display the view */
    [HttpGet]
    public IActionResult AddMovie()
    {
        return View();
    }
    
    /* When post is used and the form with information is passed, add the record to the table using _context */
    [HttpPost]
    public IActionResult AddMovie(Movie movie)
    {
        _context.Movies.Add(movie);
        _context.SaveChanges();
        
        return View("Confirmation", movie);
    }


}