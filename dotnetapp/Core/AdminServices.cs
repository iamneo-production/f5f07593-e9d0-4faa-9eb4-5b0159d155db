using dotnetapp;
using dotnetapp.Core.Interface;
using dotnetapp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetapp.Context;
using System;
using System.Collections;
using System.Linq;

namespace Institute.Core
{
    public class AdminServices : IAdmin
    {
        private readonly InstituteContext context;


        public AdminServices(InstituteContext context)
        {
            this.context = context;
        }

        public async Task<string> AddInstitute(InstituteModel institute)
        {
            try
            {
                if (context.InstituteMod != null)
                {
                    var record = await context.InstituteMod.AddAsync(institute);
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
                return context.InstituteMod.ToList();
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
                var record = context.InstituteMod.Find(instituteId);
                if (record != null)
                {
                    record.InstituteName = institute.InstituteName;
                    record.InstituteDescription = institute.InstituteDescription;
                    record.InstituteAddress = institute.InstituteAddress;
                    record.Mobile = institute.Mobile;
                    record.Email = institute.Email;
                    context.InstituteMod.Update(record);
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
                if (context.InstituteMod == null)
                {
                    return "Not Found";
                }
                var e = context.InstituteMod.Find(instituteId);
                if (e != null)
                {
                    context.InstituteMod.Remove(e);
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

