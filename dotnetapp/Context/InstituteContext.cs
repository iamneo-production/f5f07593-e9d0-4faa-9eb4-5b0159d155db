

using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;

namespace dotnetapp.Context
{
    public class InstituteContext : DbContext
    {
        public InstituteContext(DbContextOptions<InstituteContext>options): base(options)
        {
            
        }
        public DbSet<InstituteModel> InstituteMod { get; set; }
    }
}
