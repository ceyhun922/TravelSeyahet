using System.Threading.Tasks;
using Entities.Concrete;
using Entities.ViewModel;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServicesLayer.Abstract;

namespace TravelWeb.Controllers
{

    public class WritterController : Controller
    {
        private readonly UserManager<Writer> _userManager;
        private readonly SignInManager<Writer> _signInManager;
        private readonly IDestinationService _destinationService;

        public WritterController(UserManager<Writer> userManager, SignInManager<Writer> signInManager, IDestinationService destinationService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _destinationService = destinationService;
        }

        public IActionResult NewRezervations()
        {
            /*  var destinations = _destinationService.AllDestinationWithRotationService();
             foreach (var d in destinations)
             {
                 Console.WriteLine($"{d.DestinationCity} → {d.Rotasions?.Count ?? 0} rota");
             }
             return View(destinations); */
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Profile(Writer writer)
        {
            var user = await _userManager.GetUserAsync(User);

            user.UserName = writer.UserName;
            user.Email = writer.Email;
            user.WriterImage = writer.WriterImage;
            user.WriterStatus = writer.WriterStatus;

            var result = await _userManager.UpdateAsync(user);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                return RedirectToAction("Index", "Login");
            }

            var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

            if (result.Succeeded)
            {
                await _signInManager.RefreshSignInAsync(user);
                ViewBag.Succeeded = "Şifrəniz Uğurla Dəyişdirildi";
                return RedirectToAction("Profile", "Writter");
            }

            foreach (var err in result.Errors)
            {
                ModelState.AddModelError("", err.Description);
            }
            return View(model);
        }





    }
}