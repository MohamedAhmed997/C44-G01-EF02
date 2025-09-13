using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_EF02.Models
{
    internal class Course_Inst
    {
        public int CourseId { get; set; }
        public int InstructorId { get; set; }
        [Range(0, 10)]
        public int? Evaluate { get; set; }


        public Course Course { get; set; } = null!; 
        public Instructor Instructor { get; set; } = null!;

    }
}
