using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using WebApplication3.Models;

namespace WebApplication3.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
                 List<Books> books = new List<Books>
            {
                new Books
                {
                    Id = 1,
                    Title = "Dragon Ball",
                    Author = "Akira Toriyama"
                },
                new Books
                {
                    Id = 2,
                    Title = "One Piece",
                    Author = "Eiichiro Oda"
                },
                new Books
                {
                    Id = 3,
                    Title = "Naruto",
                    Author = "Masashi Kishimoto"
                }
            };
                 
            List<Customer> customers = new List<Customer>
            {
                new Customer
                {
                    FirstName = "Yuan Jasper",
                    LastName = "Rodriguez",
                    MiddleName = "G.",
                    Title = "Mr.",
                    Email = "rodriguezyuanjasp@gmail.com"
                },
                new Customer
                {
                    FirstName = "Khen",
                    LastName = "Lamela",
                    MiddleName = "B.",
                    Title = "Mr.",
                    Email = "lamela@gmail.com"
                },
                new Customer
                {
                    FirstName = "Niel Symon",
                    LastName = "Toremoro",
                    MiddleName = "F.",
                    Title = "Mr.",
                    Email = "nyol@gmail.com"
                }
            };

            // Create an instance of the HomeIndexViewModel
            HomeIndexView viewModel = new HomeIndexView
            {
                Books = books,
                Customers = customers
            };

            // Pass the ViewModel to the view
            return View(viewModel);
        }
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}