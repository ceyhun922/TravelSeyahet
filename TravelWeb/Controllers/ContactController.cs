using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}