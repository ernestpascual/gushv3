using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace gushv3.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

    
        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "Username:")]
        public string username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Password:")]
        public string password { get; set; }
        [Display(Name = "First Name:")]
        public string fName { get; set; }
        [Display(Name = "Last Name:")]
        public string Lname { get; set; }
        [Display(Name = "User Level:")]
        public string userlevel { get; set; }



   



    }
}