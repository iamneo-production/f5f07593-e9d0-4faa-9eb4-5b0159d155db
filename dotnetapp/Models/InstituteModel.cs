using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class InstituteModel
    {
        [Key]
        public int InstituteId { get; set; }
        [Required(ErrorMessage = "Institute Name is Required")]
        public string InstituteName { get; set; }
        [Required(ErrorMessage = "Institute Description is Required")]
        public string InstituteDescription { get; set; }
        [Required(ErrorMessage = "Institute Address is Required")]
        public string InstituteAddress { get; set; }
        [Required(ErrorMessage = "Mobile is Required")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }
        public string ImgUrl { get; set; }
        // public virtual List <CourseModel>courses{ get; set; }
       // [System.Text.Json.Serialization.JsonIgnore]
        //public virtual List<StudentModel>? Students { get; set; }
    }
}
