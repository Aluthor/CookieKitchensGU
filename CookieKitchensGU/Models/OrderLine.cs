using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookieKitchensGU.Models
{
    public class OrderLine
    {
        //Properties
        [Required]
        [Display(Name = "Order Line Id")]
        public int OrderLineId { get; set; }

        public int Quantity { get; set; }
        public DateTime DeliveryDate { get; set; }

        //Navigational Properties
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}