using System.Text.Json.Serialization;
using Entities.Concrete;

public class Tour
{
    public int TourId { get; set; }
    public string TourLocaion { get; set; } = string.Empty;
    public string? DTourDayNight { get; set; }
    public double TourPrice { get; set; }
    public string? TourImage { get; set; }
    public int TourCapaCity { get; set; }
    public int TourCountLimit { get; set; }
    public int TourRaiting { get; set; } = 0;
    public bool TourStatus { get; set; } = true;
    public string TourDetail { get; set; } = string.Empty;
    public DateTime TourClock { get; set; }
    public DateTime TourDateTime {get;set;}

    public int DestinationId { get; set; }

    [JsonIgnore]
    public Destination? Destination { get; set; }

    [JsonIgnore]
    public List<Rotasion>? Rotasions { get; set; }

    public int UserId { get; set; }

    [JsonIgnore]
    public Writer? Writer { get; set; }

    public int GuideID { get; set; }

    [JsonIgnore]
    public Guide? Guide { get; set; }

    public int?TestimonialID { get; set; }

    [JsonIgnore]
    public Testimonial? Testimonial { get; set; }

    public int CommentID { get; set; }

    [JsonIgnore]
    public List<Comment>? Comments { get; set; }
}
