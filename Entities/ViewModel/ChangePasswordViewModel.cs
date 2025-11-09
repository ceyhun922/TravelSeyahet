
using System.ComponentModel.DataAnnotations;

namespace Entities.ViewModel
{
    public class ChangePasswordViewModel
    {
        [DataType(DataType.Password)]
        public string OldPassword { get; set; } = string.Empty;
        [DataType(DataType.Password)]
        public string NewPassword { get; set; } = string.Empty;
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}