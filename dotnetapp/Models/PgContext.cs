using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;
using System.Reflection.Metadata;

namespace dotnetapp.Models
{
    public class PgContext : DbContext
    {
        public PgContext(DbContextOptions<PgContext>options):base(options) { }

        public DbSet<UserModel> UserT { get; set; }
        public DbSet<AdminModel> AdminT { get; set; }
        public DbSet<LoginModel> LoginT { get; set; }
        //public DbSet<InstituteModel> InstituteT { get; set; }
        //public DbSet<CourseModel> CourseT { get; set; }
        //public DbSet<StudentModel> StudentT { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Configure the primary keys for each entity
        //    modelBuilder.Entity<InstituteModel>()
        //    .HasKey(i => i.instituteId);
        //    modelBuilder.Entity<CourseModel>()
        //    .HasKey(c => c.courseId);
        //    modelBuilder.Entity<StudentModel>()
        //    .HasKey(s => s.studentId);

        //    // Configure the relationships between the entities
        //    modelBuilder.Entity<CourseModel>()
        //    .HasOne(c => c.Institute)
        //    .WithMany(i => i.courses)
        //    .HasForeignKey(c => c.InstituteId);
        //    modelBuilder.Entity<StudentModel>()
        //    .HasOne(s => s.course)
        //    .WithMany(c => c.students)
        //    .HasForeignKey(s => s.CourseId);
        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<StudentModel>()
        //        .HasOne(e => e.User)
        //    .WithOne(e => e.Student)
        //        .HasForeignKey<UserModel>(e => e.Id)
        //        .IsRequired();
        //}
    }
    
}
