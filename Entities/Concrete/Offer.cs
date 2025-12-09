using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Offer
    {
        [Key]
        public int OfferId { get; set; }
        public string? Recipe { get; set; }
        public string? Image { get; set; }
        public double Price { get; set; }
    }
}