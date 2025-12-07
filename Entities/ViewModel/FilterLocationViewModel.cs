namespace Entities.ViewModel
{
    public class FilterLocationViewModel
    {
        public string? Keyword { get; set; }
        public string? Location { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int? PriceMin { get; set; }
        public int? PriceMax { get; set; }
    }
}