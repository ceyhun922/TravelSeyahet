using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}