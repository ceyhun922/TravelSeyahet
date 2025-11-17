
using System.Text.Json.Serialization;

namespace Entities.Concrete
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string? TestimonialClient { get; set; }
        public string? TestimonialComment { get; set; }
        public string? TestimonialImage { get; set; }
        public bool TestimonialStatus { get; set; }
        [JsonIgnore]


        public List<Tour>?  Tours { get; set; }

    }
}