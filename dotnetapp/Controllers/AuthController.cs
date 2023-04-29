using dotnetapp.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using dotnetapp.Core.Interface;
using dotnetapp.Models;

namespace dotnetapp.Controllers
{
    public class AuthController : ControllerBase
    {
        private readonly IAuth auth;

        private readonly ILogger<AuthController> logger;
        public AuthController(IAuth auth)
        {
            this.auth = auth;
    
        }

#region 
        //[HttpPost]
        //[Route("UserLogin")]

        //public bool IsUserPresent(LoginModel data)
        //{
        //    var user = _context.UserT.FirstOrDefault(u => u.Email == data.Email && u.Password == data.Password);
        //    return user != null;
        //}


        //[HttpPost]
        //[Route("AdminLogin")]
        //public bool IsAdminPresent(LoginModel data)
        //{
        //    var admin = _context.AdminT.FirstOrDefault(a => a.Email == data.Email && a.Password == data.Password);
        //    return admin != null;
        //}


        //[HttpPost]
        //[Route("UserReg")]
        //public void SaveUser(UserModel user)
        //{
        //    _context.UserT.Add(user);
        //    _context.SaveChanges();
        //}


        //[HttpPost]
        //[Route("AdminReg")]
        //public void SaveAdmin(UserModel admin)
        //{

        //    if (admin.UserRole == "admin")
        //    {
        //        AdminModel a1 = new AdminModel();
        //        a1.Email = admin.Email;
        //        a1.Password = admin.Password;
        //        a1.MobileNumber = admin.MobileNumber;
        //        a1.UserRole = admin.UserRole;
        //        _context.AdminT.Add(a1);
        //        _context.SaveChanges();
        //    }
        //    else
        //    {
        //        _context.UserT.Add(admin);
        //        _context.SaveChanges();
        //    }
        //}
#endregion
        [HttpPost]
        [Route("Register")]
        [AllowAnonymous]
        public async Task<ResponseModel> RegisterUser([FromBody] UserModel userModel)
        {
            try
            {
                if (userModel != null)
                {
                    var response = await auth.RegisterUser(userModel);
                    return response;
                }
                else
                {
                    ResponseModel response = new ResponseModel();
                    response.Message = "Send proper Request with proper input";
                    response.Status = true;
                    return response;
                }

            }
            catch (System.Exception ex)
            {

                ResponseModel response = new ResponseModel();
                response.ErrorMessage = "Send proper Request with proper input";
                response.Status = false;
                response.ErrorMessage = ex.Message;
                return response;
            }
        }


        [HttpPost]
        [Route("Token")]
        public ResponseModel GenerateToken([FromBody] LoginModel loginModel)
        {
            ResponseModel response = null;
            try
            {
                if (loginModel != null)
                {
                    if (loginModel.Email!=null && loginModel.Password!=null)
                    {
                        response = auth.GenerateToken(loginModel);

                        return response;

                    }
                    else
                    {
                        response = new ResponseModel();
                        response.Message = "UserName and Password";
                        response.Status = true;
                        return response;
                    }
                }
                else
                {
                    response = new ResponseModel();
                    response.Message = "Send proper data in request";
                    response.Status = true;
                    return response;
                }
            }
            catch (System.Exception ex)
            {

                response = new ResponseModel();
                response.Message = "Oops !";
                response.ErrorMessage = ex.Message;
                response.Status = false;
                return response;
            }
        }

    }
}
