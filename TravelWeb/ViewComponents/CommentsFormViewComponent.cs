using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.ViewComponents
{
    public class CommentsFormViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int tourId)
        {

            var user = HttpContext.User.Identity;
            if (user != null && user.IsAuthenticated)
            {
                return Content("");
            }

            var comment = new Comment { TourId = tourId };

            return View(comment);
        }
    }
}