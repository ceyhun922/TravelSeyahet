using System.ComponentModel.DataAnnotations;
using Entities.Concrete;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int DestinationId { get; set; }
        public string? DestinationCity { get; set; }
        public int TourId { get; set; }
        public List<Tour>? Tours { get; set; }
    }
}