using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Controllers
{
    [AllowAnonymous]

    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }    
    }
}