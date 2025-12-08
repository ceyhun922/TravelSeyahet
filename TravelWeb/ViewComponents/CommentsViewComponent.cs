using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.ViewComponents
{
    public class CommentsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int tourId)
        {
            var comment =new Comment { TourId = tourId };
            return View(comment);
        }
    }
}