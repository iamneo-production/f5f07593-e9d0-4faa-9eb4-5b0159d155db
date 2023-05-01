using dotnetapp.Models;
using System.Threading.Tasks;

namespace dotnetapp.Core.Interface
{
    public interface IUser
    {
       Task<string> PostStudentModel(int courseid,StudentModel studentModel);
        Task<string> ViewAdmission(int courseid);
        Task<string> EditAdmission(int admissionId, StudentModel student);
        Task<string> DeleteAdmission(int admissionId);
        //string ViewStatus(int admissionId);
    }
}
