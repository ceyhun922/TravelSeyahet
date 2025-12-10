using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Controllers
{
    [AllowAnonymous]
    public class About2Controller : Controller
    {
        public IActionResult Index()
        {
         
            return View();
        }   
    }
}