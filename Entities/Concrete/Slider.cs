using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Slider
    {
        [Key]
        public int SliderId { get; set; }
        public string? SliderBanner { get; set; }
        public string? SliderTitle1 { get; set; }
        public string? SliderTitle2 { get; set; }
        public bool SliderStatus { get; set; }
    }
}