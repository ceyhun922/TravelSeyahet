using Entities.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace TravelWeb.ViewComponents
{
    public class BreadcrumpViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(List<BreadcrumpItemViewModel> items)
        {

            if (items == null || !items.Any())
                return View(new List<BreadcrumpItemViewModel>());

            foreach (var item in items)
                item.Status = false;

            items.Last().Status = true;

            return View(items);
        }
    }
}