using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G01_EF02.Models
{
    internal class Course
    {
        public int Id { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Duration must be at least 1 minute.")]
        public int? Duration { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(255)]
        public int Description { get; set; }
        public int? Topic_Id { get; set; }
    }
}
