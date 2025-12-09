using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Controllers
{
    public class OfferController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}