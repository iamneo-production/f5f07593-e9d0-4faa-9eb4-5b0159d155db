using System.ComponentModel.DataAnnotations;
using System;
using System.Text;
namespace dotnetapp.Models
{
    public class StudentModel
    {
        
            [Key]
            public int StudentId { get; set; }
            [Required(ErrorMessage = "Student Name is Required")]
            public string StudentName { get; set; }
            [Required(ErrorMessage = "Dath Of Birth is Required")]
            public DateTime StudentDOB { get; set; }
            [Required(ErrorMessage = "Address is Required")]
            public string Address { get; set; }
            [Required(ErrorMessage = "Mobile is Required")]
            public string Mobile { get; set; }
            [Required(ErrorMessage = "SSLC % is Required")]
            public int SSLC { get; set; }
            [Required(ErrorMessage = "HSC % is Required")]
            public int HSC { get; set; }
            [Required(ErrorMessage = "Diploma % is Required")]
            public int Diploma { get; set; }
            [Required]
            public string Eligibility { get; set; }

            [System.Text.Json.Serialization.JsonIgnore]
            public virtual CourseModel? Course { get; set; }
            public int CourseId { get; set; }
            //[System.Text.Json.Serialization.JsonIgnore]
            // public virtual InstituteModel? Institute { get; set; }
            //public int InstituteId { get; set; }


            //[System.Text.Json.Serialization.JsonIgnore]
            //public virtual UserModel? User { get; set; }
            //public int Id { get; set; }

        }
    }
