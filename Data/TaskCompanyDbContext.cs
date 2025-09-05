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





    }
}
