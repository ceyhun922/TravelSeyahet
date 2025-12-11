using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Controllers
{
    [AllowAnonymous]
    public class AboutController : Controller
    {
        public IActionResult Index(int id )
        {
         
            return View(id);
        }   
    }
}