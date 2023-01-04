using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MVC_HotelManagement.Models
{
    public class guestViewModel
    {
      
            [Required(ErrorMessage = "GuestName is required")]
            [Display(Name = "GuestName")]
            public string GuestName { get; set; }

            [Required(ErrorMessage = "Address is required")]
            [Display(Name = "Address")]
            public string Address{ get; set; }



            [Required(ErrorMessage = "Phno is required")]

            [Display(Name = "Phno")]
        [RegularExpression("[6-9][0-9]{9}", ErrorMessage = "Mobile Number must begin with 6,7,8 or 9")]
        public string Phno { get; set; }


            [Required(ErrorMessage = "Gender is required")]

            [Display(Name = "Gender")]
            public string Gender { get; set; }










        }
    }

