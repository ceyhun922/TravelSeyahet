using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EntityLayer.Concrete
{
    public class Rotasion
    {
        [Key]
        public int RotasionID { get; set; }
        public string? RotasionName { get; set; }
        public string? RotasionDescription { get; set; }
        public bool RotasionStatus { get; set; }
        public int DestinationId { get; set; }
        
        [JsonIgnore]   
        public Destination? Destination { get; set; }
    }
}