using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Summitworks_Project.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Student>().ToTable("StudentTable");
            //modelBuilder.Entity<Course>().ToTable("CourseTable");
            //modelBuilder.Entity<Student>()
              //  .Property(f => f.FirstName)
              //  .HasColumnName("First_Name")
              //  .HasMaxLength(50)
              //  .IsRequired()
              //  .HasDefaultValue("John");
            // add one-to-one relationship
            //modelBuilder.Entity<Course>()
            //    .HasOne(s => s.Student)
            //    .WithOne(c => c.Course)
            //    .HasForeignKey<Course>(c => c.StudentForeignKey);

            // Many to many relationship

            //modelBuilder.Entity<StudentCourse>()
            //    .HasKey(sc => new { sc.StudentID, sc.CourseId });
        }

        //public DbSet<Student> Students { get; set; }
        //public DbSet<Course> Courses { get; set; }
        public DbSet<Book> Books { get; set; }
        //public DbSet<Author> Authors { get; set; }

    }
}
