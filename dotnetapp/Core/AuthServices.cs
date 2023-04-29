
using dotnetapp.Core.Interface;
using dotnetapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Xml.Linq;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace dotnetapp.Core
{
    public class Auth : IAuth
    {

        private readonly PgContext context;
        private readonly IConfiguration configuration;
        //private readonly ILogger<Auth> logger;
        public Auth(PgContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;

        }
        public ResponseModel GenerateToken(LoginModel loginModel)
        {
            try
            {
                
                var userExists = context.UserT.FirstOrDefault(e => e.Email.ToLower() == loginModel.Email.ToLower() && e.Password.ToLower() == loginModel.Password.ToLower());
                if (userExists != null)
                {
                    var role = context.UserT.Where(c => c.Email == loginModel.Email).Select(s => s.UserRole).First();
                    var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration["Jwt:Key"]));
                    var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                    var claims = new[]
                        {
                        //new Claim(ClaimTypes.Name,loginModel.Email),
                        //new Claim(ClaimTypes.Role, userExists?.UserRole)
                        new Claim("role",role)

                    };

                    var token = new JwtSecurityToken(null,null, claims, expires: DateTime.Now.AddDays(1), signingCredentials: credentials);

                    var generatedToken = new JwtSecurityTokenHandler().WriteToken(token);


                    ResponseModel responseModel = new ResponseModel();
                    responseModel.Message = generatedToken.ToString();
                    responseModel.Status = true;
                    return responseModel;
                }
                ResponseModel response = new ResponseModel();
                response.ErrorMessage = $"No user found with username{loginModel.Email}";
                response.Status = true;
                return response;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        public async Task<ResponseModel> RegisterUser(UserModel userModel)
        {
            ResponseModel responseModel = null;
            try
            {
                var response = await context.UserT.AddAsync(userModel);
                await context.SaveChangesAsync();
                if (response != null)
                {
                    responseModel = new ResponseModel();
                    responseModel.Message = "User registered";
                    responseModel.Status = true;
                    return responseModel;
                }
                else
                {
                    responseModel = new ResponseModel();
                    responseModel.ErrorMessage = "User registration failled";
                    responseModel.Status = false;
                    return responseModel;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}


