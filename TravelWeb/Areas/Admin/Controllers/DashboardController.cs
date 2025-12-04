using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Areas.Admin.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}