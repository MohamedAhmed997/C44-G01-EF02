using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_EF02.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Salary must be greater than 0.")]
        public decimal Salary { get; set; }
        [MaxLength(150)]
        public string? Address { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "HourRateBonus must be greater than 0.")]
        public decimal HourRateBonus { get; set; }
        public int? Dept_Id { get; set; }

        #region 1 : M {Inst_Dept}
        public virtual Department Department { get; set; } = null!; // Navigation for ONE-TO-MANY (Workplace)


        #endregion

        #region INS_Mang
        public virtual Department? ManagedDepartment { get; set; } // Reverse navigation for Department head

        #endregion

        #region INS_Cousres
        public ICollection<Course_Inst> course_Insts { get; set; } = new HashSet<Course_Inst>();
        #endregion

    }
}
