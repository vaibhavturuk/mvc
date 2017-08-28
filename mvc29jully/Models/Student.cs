using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace mvc29jully.Models
{
    public class Student
    {
        public int id { get; set; }
        [Display(Name = "Enter Name")]
        [Required(ErrorMessage = "Full Name is Required", AllowEmptyStrings = false)]

        public string Name { get; set; }
        [Required(ErrorMessage = "Age is Required", AllowEmptyStrings = false)]

        public int Age { get; set; }
        [Required(ErrorMessage = "Email is Required", AllowEmptyStrings = false)]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$",
       ErrorMessage = "Please provide valid email id")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Qualification is Required", AllowEmptyStrings = false)]

        public string Qualification { get; set; }
        [Required(ErrorMessage = "Status is Required", AllowEmptyStrings = false)]

        public string Status { get; set; }

    }
}