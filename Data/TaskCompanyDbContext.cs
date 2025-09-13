using C44_G01_EF02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_EF02.Data
{
    internal class TaskCompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= .;Database=ITI-Task;Trusted_Connection = true; trustservercertificate = true");
        }
        DbSet<Student> Students { get; set; }
        DbSet<Instructor> Instructors { get; set; }
        DbSet<Topic> Topics { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Department> Departments { get; set; }
        DbSet<Stud_Course> Stud_Courses { get; set; }
        DbSet<Course_Inst> Course_Insts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ... [Other configurations for Student, Course, etc.] ...

            // 1. Configure the ONE-TO-MANY relationship: Department has many Instructors (Employees)
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)          // An Instructor has one Department...
                .WithMany(d => d.Instructors)       // ...which has many Instructors
                .HasForeignKey(i => i.Dept_Id)      // Foreign key in the Instructor table
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete to avoid cycles

            // 2. Configure the ONE-TO-ONE relationship: Department is managed by one Instructor (HOD)
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Instructor)          // A Department has one Instructor (HOD)...
                .WithOne(i => i.ManagedDepartment)  // ...who manages one Department
                .HasForeignKey<Department>(d => d.Ins_Id) // Foreign key is in the Department table
                .IsRequired(false)                  // Makes the relationship optional
                .OnDelete(DeleteBehavior.SetNull);  // If the HOD is deleted, set Ins_ID to NULL

            // ... [Other configurations for junctions, etc.] ...



            // 3.Configure the MANY-TO-ONERelationship: One Topic has many courses
            #region Crs_Ins
            // Configure Course_Inst (Junction Table)
            modelBuilder.Entity<Course_Inst>(entity =>
            {

                entity.HasKey(ci => new { ci.InstructorId, ci.CourseId });

                // Configure the relationship with Instructor
                entity.HasOne(ci => ci.Instructor)
                      .WithMany(i => i.course_Insts)
                      .HasForeignKey(ci => ci.InstructorId)
                      .OnDelete(DeleteBehavior.Cascade); // Or Restrict

                // Configure the relationship with Course
                entity.HasOne(ci => ci.Course)
                      .WithMany(c => c.course_Insts)
                      .HasForeignKey(ci => ci.CourseId)
                      .OnDelete(DeleteBehavior.Cascade);

                #endregion
            });


            #region Stu_Course

            // Configure Stud_Course (Junction Table)
            modelBuilder.Entity<Stud_Course>(entity =>
            {
                // Define the composite primary key
                entity.HasKey(sc => new { sc.StudentId, sc.CourseId });

                // Configure the relationship with Student
                entity.HasOne(sc => sc.Student)
                      .WithMany(s => s.StudCourses)
                      .HasForeignKey(sc => sc.StudentId)
                      .OnDelete(DeleteBehavior.Cascade);

                // Configure the relationship with Course
                entity.HasOne(sc => sc.Course)
                      .WithMany(c => c.Stud_Course)
                      .HasForeignKey(sc => sc.CourseId)
                      .OnDelete(DeleteBehavior.Cascade);


            });
            #endregion


























        }



    }
}
