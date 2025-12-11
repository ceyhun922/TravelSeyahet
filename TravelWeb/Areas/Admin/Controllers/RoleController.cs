
using Entities.Concrete;
using Entities.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelWeb.DTOs;

namespace TravelWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]

    public class RoleController : Controller
    {
        private readonly RoleManager<Role> _roleManager;

        public RoleController(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles
                .Select(r => new CreateRoleViewModel
                {
                     Id =r.Id,
                    Name = r.Name,
                }).ToList();;
            return View(values);
        }

        [HttpGet]
        public IActionResult AddNewRole()
        {

            return View(new CreateRoleViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AddNewRole(CreateRoleDTO dto)
        {
            if (!ModelState.IsValid)
                return View(dto);

            if (!await _roleManager.RoleExistsAsync(dto.Name))
            {
                var role = new Role
                {
                    Name = dto.Name,
                    NormalizedName = dto.Name.ToUpper()
                };

                await _roleManager.CreateAsync(role);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}