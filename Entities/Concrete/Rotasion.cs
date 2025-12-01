using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entities.Concrete
{
    public class Rotasion
    {
        [Key]
        public int RotasionID { get; set; }
        public string? RotasionName { get; set; }
        public string? RotasionDescription { get; set; }
        public bool RotasionStatus { get; set; }
        public int TourId { get; set; }
        
        public Tour? Tour { get; set; }
    }
}