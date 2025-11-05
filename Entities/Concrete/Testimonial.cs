namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string? TestimonialClient { get; set; }
        public string? TestimonialComment { get; set; }
        public string? TestimonialImage { get; set; }
        public bool TestimonialStatus { get; set; }

        public List<Destination>? Destinations { get; set; }

    }
}