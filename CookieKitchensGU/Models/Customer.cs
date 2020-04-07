using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookieKitchensGU.Models
{
    public class Customer : User
    {
        //Properties
        [Required]
        [Display(Name = "Customer Id")]
        public string CustomerId { get; set; }
        [Required]
        [Display(Name ="Delivery Address")]
        public string DeliveryAddress { get; set; }
        [Display(Name ="Telephone Number")]
        public string TelephoneNo { get; set; }
        [Display(Name = "Email Contact Method Preferred?")]
        public bool emailContactPreferred { get; set; }
        
        //Navigational Properties
        public List<Order> Orders;
    }
}