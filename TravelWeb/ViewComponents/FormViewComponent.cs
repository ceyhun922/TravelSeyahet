using Entities.Concrete;
using Entities.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace TravelWeb.ViewComponents
{
    public class FormViewComponent : ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public FormViewComponent(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var destinations = _destinationService.ListAllService(d => d.DestinationStatus == false);

            if (destinations == null || !destinations.Any())
            {
                // Konsolda yoxla
                Console.WriteLine("Destinations boşdur!");
            }

            var form = new RezerFormViewModel
            {
                Destinations = destinations,
                StartDate = DateTime.Today.AddDays(1),
                EndDate = DateTime.Today.AddDays(2)
            };

            return View(form);
        }

    }
}
