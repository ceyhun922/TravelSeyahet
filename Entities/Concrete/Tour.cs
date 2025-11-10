using EntityLayer.Concrete;

namespace Entities.Concrete
{
    public class Tour 
    {
        public int TourId { get; set; }
        public string TourLocaion { get; set; } = string.Empty;
        public string TourDetail { get; set; } = string.Empty;
        public DateTime TourClock { get; set; }
        public bool TourStatus { get; set; } = true;
        public int DestinationId { get; set; }
        public Destination? Destination { get; set; }
    }
}