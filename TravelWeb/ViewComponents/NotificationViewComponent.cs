using DAL.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.ViewComponents
{
    public class NotificationViewComponent : ViewComponent
    {
        private readonly Context _context;

        public NotificationViewComponent(Context context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = _context.Notifications?.ToList();
            return View(result);
        }
    }
}