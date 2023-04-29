using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class AdminModel
    {
        [Key]
        [Required]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Mobile Number is Required")]
        public string MobileNumber { get; set; }
        [Required(ErrorMessage = "UserRole is Required")]
        public string UserRole { get; set; }
    }
}
