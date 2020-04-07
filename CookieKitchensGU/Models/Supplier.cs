using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookieKitchensGU.Models
{
    public class Supplier
    {
        //Properties
        [Required]
        [Display(Name ="Supplier Id")]
        public int SupplierId { get; set; }
        [Required]
        [Display(Name = "Supplier Name")]
        public string SupplierName { get; set; }

        //Navigational Properties
        public List<Product> Products { get; set; }
    }
}