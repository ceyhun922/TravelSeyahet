using Entities.Concrete;

namespace EntityLayer.Concrete
{
    public class Guide
    {
        public int GuideID { get; set; }
        public string? GuideName { get; set; }
        public string? GuideDescription { get; set; }
        public string? GuideImage { get; set; }
        public string? GuideFacebookUrl { get; set; }
        public string? GuideXUrl { get; set; }
        public bool GuideStatus { get; set; }
        public List<Tour>? Tours { get; set; }
     }
}