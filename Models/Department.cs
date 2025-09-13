using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_EF02.Models
{
    internal class Department
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; }
        public int? Ins_Id { get; set; }
        [Required]
        public DateTime Hiring_Date { get; set; } = DateTime.Now;

        #region Many : 1 Student
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();

        #endregion

        #region Many : 1 Instructor
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();// Navigation for ONE-TO-MANY (Employees)

        #endregion

        #region 1:1 Inst_MNG
        public virtual Instructor? Instructor { get; set; } // Department Head

        #endregion



    }
}
