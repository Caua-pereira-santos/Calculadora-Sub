using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Calculadora.Models;

namespace Calculadora.Controllers;


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

//interface que devolve resposta para quem está solicitando
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }


   
}
