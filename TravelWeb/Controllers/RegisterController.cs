

using Entities.Concrete;
using Entities.ViewModel;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.ValidationRule;

namespace TravelWeb.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<Writer> _manager;
        private readonly SignInManager<Writer> _signInManager;

        public RegisterController(UserManager<Writer> manager, SignInManager<Writer> signInManager)
        {
            _manager = manager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

               Writer writer = new Writer
                {
                    UserName = model.Username,
                    Email = model.Mail,
                    WriterStatus = true
                };

                var result = await _manager.CreateAsync(writer, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(writer, isPersistent: false);
                    return RedirectToAction("Index", "Login");
                }
               
           
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError("",err.Description);
                }
            

            return View(model);
        }

    } 
}