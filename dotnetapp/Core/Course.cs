
using dotnetapp.Context;
using dotnetapp.Models;
using dotnetapp.Core.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;
using System.Linq;


namespace dotnetapp.Core
{
    public class Course : ICourse
    {
        private readonly CourseContext context;


        public Course(CourseContext context)
        {
            this.context = context;
        }
        public async Task<ResponseModel> AddCourse(CourseModel course)
        {
            ResponseModel responseModel = null;
            try
            {
                var record = await context.CourseT.AddAsync(course);
                await context.SaveChangesAsync();
                if (record != null)
                {
                    responseModel = new ResponseModel();
                    responseModel.Message = "Course Added";
                    responseModel.Status = true;
                    return responseModel;
                }
                else
                {
                    responseModel = new ResponseModel();
                    responseModel.ErrorMessage = "failed";
                    responseModel.Status = false;
                    return responseModel;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public IEnumerable<CourseModel> ViewCourse()
        {
            try
            {
                return context.CourseT.ToList();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<string> EditCourse(int courseId, CourseModel course)
        {
            try
            {
                if (course != null)
                {
                    if (courseId == 0)
                    {
                        return "Give proper Id";
                    }
                    var Record = context.CourseT.Find(courseId);
                    if (Record != null)

                        Record.CourseName = course.CourseName;
                    Record.CourseDescription = course.CourseDescription;
                    Record.CourseDuration = course.CourseDuration;
                    context.CourseT.Update(Record);
                    await context.SaveChangesAsync();
                    return "Course edited";
                }
                return "Want some data";
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<string> DeleteCourse(int courseId)
        {
            try
            {
                if (context.CourseT == null)
                {
                    return "Not Found";
                }

                var record = context.CourseT.Find(courseId);
                if (record != null)
                {
                    context.CourseT.Remove(record);
                    await context.SaveChangesAsync();
                    return "Course deleted";
                }
                return "Course not Found";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}