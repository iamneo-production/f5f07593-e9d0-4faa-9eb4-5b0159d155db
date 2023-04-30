using Microsoft.EntityFrameworkCore.Metadata.Internal;
using dotnetapp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;


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