using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }   
    }
}