 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    public class EmployeeDetails
    {
        [Display(Name =" Employee Id")]
        [Range(100000,999999, ErrorMessage ="You need to enter a valid Employee Id")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage ="You need to Input your first Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to Input your Last Name")]
        public string LastName { get; set; }


        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "You need to Input your Email Address")]
        public string EmailAdress { get; set; }

        [Display(Name ="ConfirmEmail")]
        [Compare("EmailAdress", ErrorMessage ="The Email and confirm Email must Match")]
        public string ConfirmEmail { get; set; }

        [Display(Name ="Password")]
        [Required(ErrorMessage ="You must have a password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength =10, ErrorMessage ="You need to provide a long enough password")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "it must Match the  password")]
        [Display(Name = "ConfirmPassword")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    } 
}