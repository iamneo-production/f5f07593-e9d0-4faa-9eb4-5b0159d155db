using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Models;
using dotnetapp.Core.Interface;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Collections.Generic;
using System;

namespace dotnetapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        ResponseModel responseModel = new ResponseModel();
        private readonly ICourse core;
        private readonly ILogger<AdminController> logger;

        public AdminController(ICourse core, ILogger<AdminController> logger)
        {
            this.core = core;
            this.logger = logger;
        }

        // Get method - to return the list of courses from database
       // [HttpGet]
       // [Route("ViewCourse")]
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
        [HttpGet]
        [Route("ViewCourse")]
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
            catch (Exception)
            {
                throw;
            }
        }
    }
}