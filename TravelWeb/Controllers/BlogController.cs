using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}