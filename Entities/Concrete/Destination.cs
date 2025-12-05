

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Entities.Concrete;
using EntityLayer.Concrete;

namespace Entities.Concrete
{
    public class Destination
    {
        [Key]
        public int DestinationId { get; set; }
        public string? DestinationCity { get; set; }
        public bool DestinationStatus { get; set; }
        public List<Tour>? Tours { get; set; }
    }
}
