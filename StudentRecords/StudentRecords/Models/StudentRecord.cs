using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StudentRecords.Models
{
    public class StudentRecord
    {
        [Display(Name = "Student ID")]
        [Required(ErrorMessage = "Enter Student ID")]
        public string studentID { get; set; }

        [Display(Name = "Student Name")]
        public string studentName { get; set; }

        [Display(Name = "Student Age")]
        public string studentAge { get; set; }

        [Display(Name = "Student Major")]
        public string studentMajor { get; set; }

        [Display(Name = "Student GPA")]
        public string studentGPA { get; set; }


    }

}