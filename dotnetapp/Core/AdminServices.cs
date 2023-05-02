using Microsoft.EntityFrameworkCore;
using dotnetapp.Core.Interface;
using dotnetapp.Context;
using dotnetapp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace dotnetapp.Core
{
    public class AdminServices : IAdmin
    {
        private readonly PgContext context;


        public AdminServices(PgContext context)
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
                if (context.StudentT == null)
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
 //----------------------------------------------------------------------------------
        public async Task<string> AddStudent(StudentModel student)
        {
            try
            {
               var record=await context.StudentT.AddAsync(student);
               await context.SaveChangesAsync();
                return "Added student";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<StudentModel> ViewStudent()
        {
            try
            {
                return context.StudentT.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> EditStudent(int studentId, StudentModel student)
        {
            try
            {
                var stu =  context.StudentT.Find(studentId);
                if (stu != null)
                {
                    stu.StudentName = student.StudentName;
                    stu.StudentDOB = student.StudentDOB;
                    stu.Address = student.Address;
                    stu.Mobile = student.Mobile;
                    stu.SSLC = student.SSLC;
                    stu.HSC = student.HSC;
                    stu.Diploma = student.Diploma;
                    stu.Eligibility = student.Eligibility;
                  //  stu.InstituteId= student.InstituteId;
                    stu.CourseId= student.CourseId;
                    context.StudentT.Update(stu);
                    await context.SaveChangesAsync();
                    return "edit successfully";
                }
                return "no student available";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> DeleteStudent(int studentId)
        {
            try
            {
                if (context.StudentT == null)
                {
                    return "Not Found";
                }
                var stu =  context.StudentT.Find(studentId);
                if (stu != null)
                {
                    context.StudentT.Remove(stu);
                    await context.SaveChangesAsync();
                    return ($"Removed student");
                }
                return $"No student is available with id {studentId} ";
            }
            catch (Exception)
            {
                throw;
            }
        }
 //----------------------------------------------------------------------
        public async Task <string> AddInstitute(InstituteModel institute)
        {
            try
            {
                if (context.StudentT != null)
                {
                    var record =await context.InstituteT.AddAsync(institute);
                    await context.SaveChangesAsync();
                    return "added";
                }
                return "Entity set is null";
            }
            catch (Exception)
            {
                throw;
            }
           
        }
      

                public IEnumerable<InstituteModel> ViewInstitute()
        {
            try
            {
                return context.InstituteT.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> EditInstitute(int instituteId, InstituteModel institute)
        {
            try
            {
                var record =  context.InstituteT.Find(instituteId);
                if (record != null)
                {
                    record.InstituteName = institute.InstituteName;
                    record.InstituteDescription = institute.InstituteDescription;
                    record.InstituteAddress = institute.InstituteAddress;
                    record.Mobile = institute.Mobile;
                    record.Email = institute.Email;
                    context.InstituteT.Update(record);
                   await context.SaveChangesAsync();
                    return "Update Success";
                }
                return "not updated";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<string> DeleteInstitute(int instituteId)
        {
            try

            {
                if (context.StudentT == null)
                {
                    return "Not Found";
                }
                var e = context.InstituteT.Find(instituteId);
                if (e != null)
                {
                    context.InstituteT.Remove(e);
                    await context.SaveChangesAsync();
                    return "Delete Success";
                }
                return "No Institute";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
