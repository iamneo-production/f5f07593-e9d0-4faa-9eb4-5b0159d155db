using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class UserModel
    {
        [Key]
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is Required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Username is Required")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Mobile Number is Required")]
        public string MobileNumber { get; set; }
        [Required(ErrorMessage = "User Role is Required")]
        public string UserRole { get; set; }

       // public virtual StudentModel Student { get; set; }
    }
}
