using dotnetapp.Context;
using dotnetapp.Models;
using System.Threading.Tasks;
using System;

namespace dotnetapp.Interface.Core
{
        public class UserServices : IUser
        {
            private readonly StudentContext context;

            public UserServices(StudentContext context)
            {
                this.context = context;
            }

            public async Task<string> PostStudentModel(int Courseid, StudentModel studentModel)
            {
                try
                {
                    if (context.StudentT == null)
                    {
                        return ("Entity set is null.");
                    }
                    // studentModel.InstituteId = Instituteid;
                    studentModel.CourseId = Courseid;
                    context.StudentT.Add(studentModel);
                    await context.SaveChangesAsync();

                    return "Created";
                }
                catch (Exception)
                {
                    throw;
                }
            }


            public async Task<string> DeleteAdmission(int admissionId)
            {
                try
                {
                    if (context.StudentT == null)
                    {
                        return "Not Found";
                    }
                    var stu =  context.StudentT.Find(admissionId);
                    if (stu != null)
                    {
                        context.Remove(stu);
                        await context.SaveChangesAsync();
                        return ($"Removed student");
                    }
                    return $"No student is available with id {admissionId} ";
                }
                catch (Exception)
                {
                    throw;
                }
            }

            public async Task<string> EditAdmission(int admissionId, StudentModel student)
            {
                try
                {
                    var stu =  context.StudentT.Find(admissionId);
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

            public async Task<string> ViewAdmission(int courseid)
            {
                try
                {
                    if (context.StudentT == null)
                    {
                        return "Not Found";
                    }
                    var studentModel = await context.StudentT.FindAsync(courseid);

                    if (studentModel == null)
                    {
                        return "Not Found";
                    }

                    return "";
                }
                catch (Exception)
                {
                    throw;
                }

            }

            //public IEnumerable<StudentModel> ViewAdmission()
            //{
            //    throw new NotImplementedException();
            //}
        }
    }
