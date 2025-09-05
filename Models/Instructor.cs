using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    }
}
