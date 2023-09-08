// #12 Set up the Pet Controller and copy everything from the Home Controller to this file... update the controller to pet istead of home

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Connection.Models;

namespace Connection.Controllers;

public class PetController : Controller
{
    private readonly ILogger<PetController> _logger;

    public PetController(ILogger<PetController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
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
