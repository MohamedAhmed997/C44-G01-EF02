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
        [MaxLength(100)]
        public string Name { get; set; }
        public int? Ins_Id { get; set; }
        [Required]
        public DateTime Hiring_Date { get; set; } = DateTime.Now;


    }
}
