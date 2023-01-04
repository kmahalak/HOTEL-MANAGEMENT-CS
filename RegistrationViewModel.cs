using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MVC_HotelManagement.Models
{
    public class RegistrationViewModel
    {

        [Required(ErrorMessage = "FirstName is required")]
        [Display(Name = "FirstName")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "LastName is required")]
        [Display(Name = "LastName")]
        public string LastName { get; set; }



        [Required(ErrorMessage = "Username is required")]

        [Display(Name = "Username")]
        public string Username { get; set; }



        [Required(ErrorMessage = "Role is Required")]
        [Display(Name = "Role")]
        public string Role { get; set; }



        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Display(Name = "Confirmpassword")]
        [Required(ErrorMessage = "Confirmpassword")]
        public string Confirmpassword { get; set; }


    }
}