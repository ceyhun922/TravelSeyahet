using System.ComponentModel.DataAnnotations;
using Entities.Concrete;

namespace EntityLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int DestinationId { get; set; }
        public string? DestinationCity { get; set; }
        public string? DestinationDayNight { get; set; }
        public double DestinationPrice { get; set; }
        public string? DestinationImage { get; set; }
        public int CapaCity { get; set; }
        public DateTime DestinationTime { get; set; } = DateTime.Now;
        public int DestinationCountLimit { get; set; }
        public bool DestinationStatus { get; set; }
        public List<Rotasion>? Rotasions { get; set; }
        public int? UserId { get; set; }

        public Writer? Writer { get; set; }

        public int GuideID { get; set; }

        public Guid Guid { get; set; }

        public int TestimonialID { get; set; }

        public Testimonial? Testimonial { get; set; }

        public int CommentID { get; set; }

        public List<Comment>? Comments { get; set; }




    }
}