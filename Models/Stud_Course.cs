using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_EF02.Models
{
    internal class Stud_Course
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        [Range(0, 100)]
        public string? Grade { get; set; }

        public Student Student { get; set; } = null! ;
        public Course Course { get; set; } = null!; 
    }
}
