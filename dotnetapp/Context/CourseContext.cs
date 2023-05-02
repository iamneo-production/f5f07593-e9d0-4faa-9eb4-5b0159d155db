using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;

namespace dotnetapp.Context
{
    public class CourseContext : DbContext

    {
        public CourseContext(DbContextOptions<CourseContext> options) : base(options) { }

        public DbSet<CourseModel> CourseT { get; set; }
    }


}






















