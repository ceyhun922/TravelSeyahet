using DAL.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.Controllers
{
    public class SliderController : Controller
    {
        private readonly Context _context;

        public SliderController(Context context)
        {
            _context = context;
        }


    }
}