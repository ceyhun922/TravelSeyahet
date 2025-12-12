using Entities.Concrete;

namespace Entities.ViewModel
{
    public class RezerFormViewModel
    {
        public string? SelectedDestination {get;set;}

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public List<Destination>? Destinations {get;set;}
    }
}