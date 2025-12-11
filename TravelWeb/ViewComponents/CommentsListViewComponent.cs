using DAL.Concrete;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.ViewComponents
{
    public class CommentsListViewComponent : ViewComponent
    {
        private readonly Context _context;
        private readonly ICommentService _commentService;

        public CommentsListViewComponent(ICommentService commentService, Context context)
        {
            _commentService = commentService;
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int tourId)
        {
            var values =_context.Comments.Where(x => x.TourId == tourId).ToList();

            return View(values);
        }
    }
}