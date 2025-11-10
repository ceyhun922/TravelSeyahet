using Microsoft.AspNetCore.Identity;

namespace Entities.Concrete
{
    public class Writer : IdentityUser<int>
    {
        public string WriterImage { get; set; } = string.Empty;
        public bool WriterStatus { get; set; } = true;
    }
}
