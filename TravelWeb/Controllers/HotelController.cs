using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }    
    }
}