using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace dotnetapp.Models
{
    public class CourseModel
    {
        [Key]
        public int CourseId { get; set; }
        [Required(ErrorMessage = "Course Name is Required")]
        public string CourseName { get; set; }
        [Required(ErrorMessage = "Course Description is Required")]
        public string CourseDescription { get; set; }
        [Required(ErrorMessage = "Course Duration is Required")]
        public int CourseDuration { get; set; }

        //  public virtual List<InstituteModel> institute { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
            
        public virtual List<StudentModel>?Students { get; set; }
    }
}
