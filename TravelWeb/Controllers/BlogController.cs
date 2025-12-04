using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Controllers
{
    [AllowAnonymous]

    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}