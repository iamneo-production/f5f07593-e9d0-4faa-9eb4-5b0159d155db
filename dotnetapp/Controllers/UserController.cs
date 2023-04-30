using Microsoft.AspNetCore.Mvc;
using dotnetapp.Interface;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
   
        [Route("api/[controller]")]
        [ApiController]
        public class UserController : ControllerBase
        {
            private readonly IUser user;

            public UserController(IUser user)
            {
                this.user = user;
            }

            [HttpPost]
            [Route("AddAdmission")]
            public ActionResult<ResponseModel> PostStudentModel(int courseid, StudentModel studentModel)
            {
                user.PostStudentModel(courseid, studentModel);
                ResponseModel responseModel = new ResponseModel();
                responseModel.Message = "Course Enrolled";
                responseModel.Status = true;
                responseModel.ErrorMessage = null;
                return responseModel;
            }
            [HttpGet]
            [Route("ViewEnrolled")]
            public ActionResult<ResponseModel> ViewAdmission(int courseid)
            {
                user.ViewAdmission(courseid);
                ResponseModel responseModel = new ResponseModel();
                responseModel.Message = "Enrolled Course";
                responseModel.Status = true;
                responseModel.ErrorMessage = null;
                return responseModel;
            }

            [HttpPut]
            [Route("EditAdmission")]
            public ActionResult<ResponseModel> EditAdmission(int admissionId, StudentModel student)
            {
                user.EditAdmission(admissionId, student);
                ResponseModel responseModel = new ResponseModel();
                responseModel.Message = "Admission details edited";
                responseModel.Status = true;
                responseModel.ErrorMessage = null;
                return responseModel;
            }
            [HttpDelete]
            [Route("DeleteAdmission")]
            public ActionResult<ResponseModel> DeleteAdmission(int admissionId)
            {
                user.DeleteAdmission(admissionId);
                ResponseModel responseModel = new ResponseModel();
                responseModel.Message = "Admission details deleted";
                responseModel.Status = true;
                responseModel.ErrorMessage = null;
                return responseModel;
            }
        }
    }

