using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Controllers
{
    
    public class WritterController : Controller
    {
        private readonly UserManager<Writer> _userManager;

        public WritterController(UserManager<Writer> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Profile(Writer writer)
        {
            var user =await _userManager.GetUserAsync(User);

            user.UserName =writer.UserName;
            user.Email =writer.Email;
            user.WriterImage =writer.WriterImage;
            user.WriterStatus = writer.WriterStatus;

            var result = await _userManager.UpdateAsync(user);

            return RedirectToAction(nameof(Index));
        }
    }
}