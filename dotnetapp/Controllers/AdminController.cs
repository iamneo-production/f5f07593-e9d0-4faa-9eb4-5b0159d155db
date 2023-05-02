using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnetapp.Core;
using dotnetapp.Core.Interface;
using dotnetapp.Models;
using System;
using System.Collections.Generic;

namespace dotnetapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        ResponseModel responseModel = new ResponseModel();
        private readonly IAdmin core;
        private readonly ILogger<AdminController> logger;

        public AdminController(IAdmin core, ILogger<AdminController> logger)
        {
            this.core = core;
            this.logger = logger;
        }

        // Get method - to return the list of courses from database
        [HttpGet]
        [Route("ViewCourse")]

        //public ActionResult<ResponseModel> ViewCourse()
        //{
        //    try
        //    {
        //        logger.LogInformation("Admin Controller");
        //        logger.LogInformation("Calling ViewCourse Method");
        //        var record = core.ViewCourse();
        //        logger.LogInformation($"Got response from the database with values {record}");
        //        responseModel.Response = new
        //        {
        //            record
        //        };
        //        responseModel.Status = true;
        //        responseModel.Message = "Success";
        //        return responseModel;

        //    }
        //    catch (Exception ex)
        //    {
        //        logger.LogError($" An exception has occured while running the program with message {ex.Message}");
        //        throw ex;
        //    }
        //}
        public IEnumerable<CourseModel> ViewCourse()
        {
            try
            {
                var e = core.ViewCourse();
                return e;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Post method - to insert the course data into database
        [HttpPost]
        [Route("addCourse")]
        public ActionResult<ResponseModel> AddCourse(CourseModel coursemodel)
        {
            try
            {
                logger.LogInformation("Admin Controller");
                logger.LogInformation("Calling AddCourse Method");
                var record = core.AddCourse(coursemodel);
                logger.LogInformation($"Got response from the database with values {record}");

                responseModel.Message = "Course Added";
                responseModel.Status = true;
                return responseModel;
            }
            catch (Exception ex)
            {
                responseModel.Message = "Something Went Wrong";
                logger.LogError($" An exception has occured while running the program with message {ex.Message}");
                responseModel.Status = false;
                responseModel.ErrorMessage = ex.Message;
                return responseModel;
            }
        }

        // Put method - to update already existing course record in the database
        [HttpPut]
        [Route("editCourse")]
        public ActionResult<ResponseModel> EditCourse(int id, CourseModel courseModel)
        {
            try
            {
                logger.LogInformation("Admin Controller");
                logger.LogInformation("Calling EditCourse Method");
                var record = core.EditCourse(id, courseModel);
                logger.LogInformation($"Got response from the database with values {record}");
                responseModel.Message = "Course edited";
                responseModel.Status = true;
                return responseModel;
            }
            catch (Exception ex)
            {
                responseModel.Message = "Something Went Wrong";
                logger.LogError($" An exception has occured while running the program with message {ex.Message}");
                responseModel.Status = false;
                responseModel.ErrorMessage = ex.Message;
                return responseModel;
            }
        }

        // Delete method - to delete a course record from the database
        [HttpDelete]
        [Route("deleteCourse")]
        public ActionResult<ResponseModel> DeleteCourse(int id)
        {
            try
            {
                logger.LogInformation("Admin Controller");
                logger.LogInformation("Calling DeletedCourse Method");
                var record = core.DeleteCourse(id);
                logger.LogInformation($"Deleted Course with Id : {record.Id}");

                responseModel.Message = "Course deleted";
                responseModel.Status = true;
                return responseModel;
            }
            catch (Exception ex)
            {
                responseModel.Message = "Something Went Wrong";
                logger.LogError($" An exception has occured while running the program with message {ex.Message}");
                responseModel.Status = false;
                responseModel.ErrorMessage = ex.Message;
                return responseModel;
            }
        }
        //-------------------------------------------------------------------------

        [HttpGet]
        [Route("ViewStudent")]
        public IEnumerable<StudentModel> ViewStudent()
        {
            try
            {
                var e = core.ViewStudent();
                return e;
            }
            catch (Exception)
            {
                throw;
            }
        }
            //public ActionResult<ResponseModel> ViewStudent()
            //{
            //    try
            //    {
            //        logger.LogInformation("Admin Controller");
            //        logger.LogInformation("Calling ViewStudent Method");
            //        var record = core.ViewStudent();
            //        logger.LogInformation($"Got response from the database with values {record}");
            //        responseModel.Response = new
            //        {
            //            Students = record
            //        };
            //        responseModel.Status = true;
            //        responseModel.Message = "Success";
            //        return responseModel;
            //    }
            //    catch (Exception ex)
            //    {
            //        responseModel.Message = "Something Went Wrong";
            //        logger.LogError($" An exception has occured while running the program with message {ex.Message}");
            //        responseModel.Status = false;
            //        responseModel.ErrorMessage = ex.Message;
            //        return responseModel;
            //    }
            //}
            // Post method - to insert the student data into database
            [HttpPost]
        [Route("AddStudent")]
        public ActionResult<ResponseModel> AddStudent(StudentModel student)
        {
            try
            {
                logger.LogInformation("Admin Controller");
                logger.LogInformation("Calling AddStudent Method");
                var record = core.AddStudent(student);
                logger.LogInformation($"Got response from the database with values {record}");
                responseModel.Message = "Student added";
                responseModel.Status = true;
                responseModel.ErrorMessage = null;
                return responseModel;
            }
            catch (Exception ex)
            {
                responseModel.Message = "Something Went Wrong";
                logger.LogError($" An exception has occured while running the program with message {ex.Message}");
                responseModel.Status = false;
                responseModel.ErrorMessage = ex.Message;
                return responseModel;
            }
        }
        // Delete method - to delete a student record from the database
        [HttpDelete]
        [Route("deleteStudent")]
        public ActionResult<ResponseModel> deleteStudent(int studentId)
        {
            try
            {

                var record= core.DeleteStudent(studentId);
                responseModel.Message = "Student deleted";
                responseModel.Status = true;
                responseModel.ErrorMessage = null;
                return responseModel;
            }
            catch (Exception ex)
            {
                responseModel.Message = "Something Went Wrong";
                logger.LogError($" An exception has occured while running the program with message {ex.Message}");
                responseModel.Status = false;
                responseModel.ErrorMessage = ex.Message;
                return responseModel;
            }
        }
        // Put method - to update already existing student record in the database
        [HttpPut]
        [Route("editStudent")]
        public ActionResult<ResponseModel> editStudent(int Id, StudentModel student)
        {
            try
            {
                logger.LogInformation("Admin Controller");
                logger.LogInformation("Calling EditStudent Method");
                var record = core.AddStudent(student);
                logger.LogInformation($"Got response from the database with values {record}");
                responseModel.Message = "Student Edited";
                responseModel.Status = true;
                responseModel.ErrorMessage = null;
                return responseModel;
            }
            catch (Exception ex)
            {
                responseModel.Message = "Something Went Wrong";
                logger.LogError($" An exception has occured while running the program with message {ex.Message}");
                responseModel.Status = false;
                responseModel.ErrorMessage = ex.Message;
                return responseModel;
            }
        }
        //------------------------------------------------------------------------------------
        // Post method - to insert the institute data into database
        [HttpPost]
        [Route("AddInstitute")]
        public ActionResult<ResponseModel> AddInstitute(InstituteModel institute)
        {
            try
            {
                core.AddInstitute(institute);
                responseModel.Message = "Institute Added";
                responseModel.Status = true;
                responseModel.ErrorMessage = null;
                return responseModel;
            }
            catch (Exception ex)
            {
                responseModel.Message = "Something Went Wrong";
                logger.LogError($" An exception has occured while running the program with message {ex.Message}");
                responseModel.Status = false;
                responseModel.ErrorMessage = ex.Message;
                return responseModel;
            }
        }
        // Delete method - to delete a institute record from the database
        [HttpDelete]
        [Route("DeleteInstitute")]
        public ActionResult<ResponseModel> DeleteInstitute(int instituteId)
        {
            try
            {
                logger.LogInformation("Admin Controller");
                logger.LogInformation("Calling DeletedInstitute Method");
                var record = core.DeleteInstitute(instituteId);
                logger.LogInformation($"Deleted Institute with Id : {record.Id}");
               
                responseModel.Message = "Institute Deleted";
                responseModel.Status = true;
                responseModel.ErrorMessage = null;
                return responseModel;
            }
            catch (Exception ex)
            {
                responseModel.Message = "Something Went Wrong";
                logger.LogError($" An exception has occured while running the program with message {ex.Message}");
                responseModel.Status = false;
                responseModel.ErrorMessage = ex.Message;
                return responseModel;
            }
        }


        // Put method - to update already existing institute record in the database
        [HttpPut]
        [Route("editInstitute")]
        public ActionResult<ResponseModel> EditInstitute(int instituteId, InstituteModel institute)
        {
            try
            {
                logger.LogInformation("Admin Controller");
                logger.LogInformation("Calling EditInstitute Method");
                var record = core.EditInstitute(instituteId, institute);
                logger.LogInformation($"Got response from the database with values {record}");
                responseModel.Message = "Institute Edited";
                responseModel.Status = true;
                responseModel.ErrorMessage = null;
                return responseModel;
            }
            catch (Exception ex)
            {
                responseModel.Message = "Something Went Wrong";
                logger.LogError($" An exception has occured while running the program with message {ex.Message}");
                responseModel.Status = false;
                responseModel.ErrorMessage = ex.Message;
                return responseModel;
            }
        }



        [HttpGet]
        [Route("viewInstitute")]
        public IEnumerable<InstituteModel> ViewInstitute()
        {
            try
            {
                var e = core.ViewInstitute();
                return e;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
