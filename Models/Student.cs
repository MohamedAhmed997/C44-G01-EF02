using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_EF02.Models
{
    internal class Student
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string FName { get; set; }
        [MaxLength(50)]
        public string LName { get; set; }
        [MaxLength(150)]
        public string? Address { get; set; }
        [Range(18, 60)]
        public int Age { get; set; }
        public int Dep_Id { get; set; }
        
        


    }
}
