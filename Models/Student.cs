using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace oe.Models
{
    public partial class Student
    {
        public int StuId { get; set; }

        [Display(Name = "Students Class")]
        public int? ClassId { get; set; }

        [Display(Name = "Teacher Name")]
        public int? TeacherId { get; set; }

        [Required(ErrorMessage = "Enter Student Name")]
        [Display(Name = "Student Name")]
        public string StuName { get; set; }

        [Required(ErrorMessage = "Enter Default Password")]
        [Display(Name = "Student Password")]

        public string StuPassword { get; set; }

        [Display(Name = "Student Image")]
        public string StuImage { get; set; }
    }
}
