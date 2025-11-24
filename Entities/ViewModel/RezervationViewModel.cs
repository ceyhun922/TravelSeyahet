using Entities.Concrete;

namespace Entities.ViewModel
{
    public class RezervationViewModel
    {
        public int DestinationId { get; set; }
        public int TourId { get; set; }
        public int CountPerson { get; set; }
        public DateTime RezervationDate { get; set; }
        public TimeOnly RezervationTime { get; set; }

        public RezervationStatus RezervationStatus { get; set; } = RezervationStatus.Pending;

        public string? Description { get; set; }
    }
}
