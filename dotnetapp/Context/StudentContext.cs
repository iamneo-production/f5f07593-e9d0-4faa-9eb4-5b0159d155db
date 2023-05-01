using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;
using System.Reflection.Metadata;
namespace dotnetapp.Context
{
    public class StudentContext : DbContext
    {

        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<CourseModel> CourseT { get; set; }
        public DbSet<StudentModel> StudentT { get; set; }

        
    }

}
