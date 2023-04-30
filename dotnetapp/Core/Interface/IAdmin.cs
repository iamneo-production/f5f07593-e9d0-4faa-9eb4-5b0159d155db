using dotnetapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetapp.Core.Interface
{
    public interface IAdmin
    {
        Task<string> AddInstitute(InstituteModel institute);
        IEnumerable<InstituteModel> ViewInstitute();
        Task<string> EditInstitute(int instituteId, InstituteModel institute);
        Task<string> DeleteInstitute(int instituteId);
    }
}
