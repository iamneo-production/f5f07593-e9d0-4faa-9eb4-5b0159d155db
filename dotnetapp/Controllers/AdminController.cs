using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dotnetapp.Core.Interface;
using dotnetapp.Models;
using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace PgAdmission.Controllers
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
            catch (Exception)
            {
                throw;
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
            catch (Exception)
            {
                throw;
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
            catch (Exception)
            {
                throw;
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
