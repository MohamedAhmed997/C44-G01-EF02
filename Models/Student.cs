using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_EF02.Models
{
    internal class Student
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string FName { get; set; }
        [Required,MaxLength(50)]
        public string LName { get; set; }
        [MaxLength(150)]
        public string? Address { get; set; }
        [Required,Range(18, 60)]
        public int Age { get; set; }
        public int Dep_Id { get; set; }

        #region 1 : M {student_Dept}
        public virtual Department Department { get; set; } = null!;

        #endregion

        #region M ; M Cousrses
        public ICollection<Stud_Course> StudCourses { get; set; } = new HashSet<Stud_Course>();

        #endregion


    }
}
