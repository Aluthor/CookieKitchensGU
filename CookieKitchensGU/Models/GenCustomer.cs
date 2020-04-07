using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookieKitchensGU.Models
{
    public class GenCustomer : Customer
    {
        //Properties
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Is Activated")]
        public bool IsActivated { get; set; }
        [Required]
        [Display(Name = "Is Suspended")]
        public bool IsSuspended { get; set; }
    }
}