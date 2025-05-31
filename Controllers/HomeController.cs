using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyFinance.Models;

namespace MyFinance.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var sankeyData = new SankeyDataModel
        {
            NodeLabels = new[] { "Plat", "Vedľajší príjem", "Celkový príjem", "Bývanie", "Jedlo", "Doprava" },
            NodeColors = new[] { "blue", "blue", "green", "red", "red", "red" },
            LinkSource = new[] { 0, 1, 2, 2, 2 },
            LinkTarget = new[] { 2, 2, 3, 4, 5 },
            LinkValue  = new[] { 2000, 500, 800, 400, 200 }
        };
        return View(sankeyData);
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
