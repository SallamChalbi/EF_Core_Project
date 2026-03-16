using EF_Core_Project.Configurations;
using EF_Core_Project.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Project.Contexts
{
    internal class ITIProjectDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=.; Database=ITIProject; Trusted_Connection=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new InstructorConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            //or
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder.Entity<StudentCourse>().HasKey(SC => new { SC.StudentId, SC.CourseId });
            modelBuilder.Entity<CourseInstructor>().HasKey(CI => new { CI.InstructorId, CI.CourseId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topic { get; set; }
    }
}
