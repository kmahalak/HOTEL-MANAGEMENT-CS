using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MVC_HotelManagement.Models
{
    public class ReservationViewModel
    {
        [Required(ErrorMessage = "Code is required")]
        [Display(Name = "Code")]
        public int Code { get; set; }


        [Display(Name = "NoofChildrens")]
        public int NoofChildrens { get; set; }



        [Required(ErrorMessage = "NoofAdults are required")]

        [Display(Name = "NoofAdults")]
        public int NoofAdults { get; set; }



        [Required(ErrorMessage = "Checkin is Required")]
        [Display(Name = "Checkin")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Checkin { get; set; }



        [Display(Name = "Checkout")]
        [Required(ErrorMessage = "Checkout is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]

        public DateTime Checkout { get; set; }



        [Required(ErrorMessage = "NoofRooms is required")]

        [Display(Name = "NoofRooms")]
        public string NoofRooms { get; set; }



        [Display(Name = "Phno")]

        [Required(ErrorMessage = "Phno is required")]
        [RegularExpression("[6-9][0-9]{9}", ErrorMessage = "Mobile Number must begin with 6,7,8 or 9")]
        public string Phno { get; set; }








    }
}

    
