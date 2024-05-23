using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCFORM.Models
{
    public class EmployeeModel
    {
        [Required(ErrorMessage = "Insert ID", AllowEmptyStrings = false)]
        public int Emp_Id { get; set; }

        [Required(ErrorMessage = "Enter Name", AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Age", AllowEmptyStrings = false)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Select Gender.", AllowEmptyStrings = false)]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Enter Mobile Number", AllowEmptyStrings = false)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Enter Valid Mobile No")]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Enter Valid Mobile No")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Insert Password", AllowEmptyStrings = false)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Insert Conform Password", AllowEmptyStrings = false)]
        [Compare("Password", ErrorMessage = "The password and re-type password not match.")]
        public string ConPassword { get; set; }

        [Required(ErrorMessage = "Insert Email", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage = "Enter Valid Email Id")]
        [RegularExpression("^([a-zA-Z0-9_\\.\\-])+\\@(([a-zA-Z\\-])+\\.)+([a-zA-Z]{2,6})$", ErrorMessage = "Enter Valid Email Id")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Select Position", AllowEmptyStrings = false)]
        public string Postion { get; set; }

        [Required(ErrorMessage = "Insert Salary", AllowEmptyStrings = false)]
        public string Salary { get; set; }

        [Required(ErrorMessage = "Insert DOB", AllowEmptyStrings = false)]
        public string DOB { get; set; }
    }
}