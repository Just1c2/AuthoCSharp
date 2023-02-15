using AuthoEx.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthoEx.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Subject>? Subjects { get; set; }
        public DbSet<Exam>? Exams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
           new Student
           {
               StudentId = 1,
               Name = "John Doe",
               DateOfBirth = new DateTime(1995, 5, 21),
               Email = "johndoe@gmail.com",
               Address = "123 Main St."
           },
           new Student
           {
               StudentId = 2,
               Name = "Jane Doe",
               DateOfBirth = new DateTime(1997, 3, 17),
               Email = "janedoe@gmail.com",
               Address = "456 Main St."
           },
           new Student
           {
               StudentId = 3,
               Name = "Bob Smith",
               DateOfBirth = new DateTime(1996, 8, 12),
               Email = "bobsmith@gmail.com",
               Address = "789 Main St."
           }
       );

            modelBuilder.Entity<Subject>().HasData(
                new Subject
                {
                    SubjectId = 1,
                    SubjectName = "Math",
                    SubjectCode = "MATH101",
                    Description = "Introduction to Mathematics",
                    StartDate = new DateTime(2022, 1, 1),
                    EndDate = new DateTime(2022, 12, 31)
                },
                new Subject
                {
                    SubjectId = 2,
                    SubjectName = "English",
                    SubjectCode = "ENGL101",
                    Description = "Introduction to English",
                    StartDate = new DateTime(2022, 1, 1),
                    EndDate = new DateTime(2022, 12, 31)
                },
                new Subject
                {
                    SubjectId = 3,
                    SubjectName = "History",
                    SubjectCode = "HIST101",
                    Description = "Introduction to History",
                    StartDate = new DateTime(2022, 1, 1),
                    EndDate = new DateTime(2022, 12, 31)
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}