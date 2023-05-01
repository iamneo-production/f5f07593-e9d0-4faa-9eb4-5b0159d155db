using Microsoft.EntityFrameworkCore.Metadata.Internal;
using dotnetapp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dotnetapp.Core.Interface
{
    public interface IAdmin
    {
        Task<string> AddStudent(StudentModel student);
        IEnumerable<StudentModel> ViewStudent();
        Task<string> EditStudent(int studentId, StudentModel student);
        Task<string> DeleteStudent(int studentId);

        public Task<ResponseModel> AddCourse(CourseModel course);
        
            IEnumerable<CourseModel> ViewCourse();
        Task<string> EditCourse(int courseId, CourseModel course);
        Task<string> DeleteCourse(int courseId);


        Task<string> AddInstitute(InstituteModel institute);
        IEnumerable<InstituteModel> ViewInstitute();
        Task<string> EditInstitute(int instituteId, InstituteModel institute);
        Task<string> DeleteInstitute(int instituteId);

    }
}
