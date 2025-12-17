using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class SettingsController : Controller
    {
        private readonly IWriterService _writerService;
        private readonly UserManager<Writer> _userManager;
        private readonly IWebHostEnvironment _env;

        public SettingsController(IWriterService writerService, UserManager<Writer> userManager, IWebHostEnvironment env)
        {
            _writerService = writerService;
            _userManager = userManager;
            _env = env;
        }

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Profile(Writer writer, IFormFile file)
        {
            var user = await _userManager.GetUserAsync(User);

            if (file != null && file.Length > 0)
            {
                var extension = Path.GetExtension(file.FileName).ToLower();
                var allowed = new[] { ".jpg", ".png", ".jpeg", ".svg", ".webp" };

                if (!allowed.Contains(extension))
                {
                    return Content("Desteklenmeyen Fayl");
                }

                var FolderPath = Path.Combine(_env.WebRootPath, "UserImages");

                if (!Directory.Exists(FolderPath))
                {
                    Directory.CreateDirectory(FolderPath);
                }

                var fileName = Guid.NewGuid() + extension;
                var fullPath = Path.Combine(FolderPath, fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                user.WriterImage = "/UserImages/" + fileName;
            }

            user.WriterStatus = writer.WriterStatus;
           /*  user.PhoneNumber =writer.PhoneNumber; */

            var result = await _userManager.UpdateAsync(user);
            TempData["success"] ="Melumat Yenilendi";

            return RedirectToAction("Index","Dashboard",new { Area = "Admin" });
        }

        public IActionResult ChangePassword()
        {
            return View();
        }
    }
}