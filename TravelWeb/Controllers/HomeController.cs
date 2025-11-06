using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TravelWeb.Models;

namespace TravelWeb.Controllers;

public class HomeController : Controller
{


    public IActionResult Index()
    {
        return View();
    }

}
