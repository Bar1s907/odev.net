using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _11atpa.Models;

namespace _11atpa.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        ViewData["Name"] = "Barış Gürkan";
        return View();
    }

    public IActionResult Contact()
    {

        return View();
    }

    public IActionResult Teams()
    {
        string[] teamList =
        {
            "Fenerbahçe",
            "Beşiktaş",
            "Arsenal",
            "Ajax",
            "Real Madrid",
           
        };
        ViewBag.Teams = teamList;
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
