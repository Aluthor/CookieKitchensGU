using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookieKitchensGU.Models
{
    public class TradeCust : Customer
    {
        //Properties
        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Required]
        public string Username { get; set; }

        //Navigational Properties
        public List<Invoice> Invoices{ get; set; }
        public int MyProperty { get; set; }
    }
}