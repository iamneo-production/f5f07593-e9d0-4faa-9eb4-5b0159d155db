using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using PG_Admission_Portal.Model;
 using dotnetapp.Models;
using System.Threading.Tasks;
using System.Collections.Generic;



namespace dotnetapp.Core.Interface
{
    public interface ICourse
    {

        public Task<ResponseModel> AddCourse(CourseModel course);

        IEnumerable<CourseModel> ViewCourse();
        Task<string> EditCourse(int courseId, CourseModel course);
        Task<string> DeleteCourse(int courseId);
    }
}