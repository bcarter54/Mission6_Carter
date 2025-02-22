using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

    /* When AddMovie is called, display the view with categories and a new movie object provided */
    [HttpGet]
    public IActionResult AddMovie()
    {
        ViewBag.Categories = _context.Categories.OrderBy(x => x.CategoryName).ToList();
        
        return View(new Movie());
    }
    
    /* When post is used and the form with information is passed, add the record to the table using _context */
    [HttpPost]
    public IActionResult AddMovie(Movie movie)
    {
        if (ModelState.IsValid)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            
            return View("Confirmation", movie);
        }

        // If model is invalid, reload form with categories
        ViewBag.Categories = _context.Categories.ToList();
        return View(movie);
    }

    /* Display all movies with the categories as well */
    public IActionResult EditMovieList()
    {
        var movieList = _context.Movies.Include(x=>x.Category).ToList();    
        
        return View(movieList);
    }

    /* Receive the movie id of the movie to edit and display it on the add movies page for editing*/
    [HttpGet]
    public IActionResult EditMovie(int edit)
    {
        var movieToEdit = _context.Movies.Single(x => x.MovieId == edit);
        
        ViewBag.Categories = _context.Categories.ToList();
        
        return View("AddMovie",movieToEdit);
    }

    /* Update the chosen movie in the database, then go back to the edit movie list */
    [HttpPost]
    public IActionResult EditMovie(Movie movie)
    {
        _context.Update(movie);
        _context.SaveChanges();
        
        return RedirectToAction("EditMovieList");
    }
 
    /* Display the movie to be deleted on delete page */
    [HttpGet]
    public IActionResult DeleteMovie(int delete)
    {
        var movieToDelete = _context.Movies.Single(x => x.MovieId == delete);
        
        ViewBag.Categories = _context.Categories.ToList();
        
        return View(movieToDelete);
    }
    
    /* Receive movie and delete from database*/
    [HttpPost]
    public IActionResult DeleteMovie(Movie movie)
    {
        _context.Movies.Remove(movie);
        _context.SaveChanges();
        
        return RedirectToAction("EditMovieList");
    }
    

}