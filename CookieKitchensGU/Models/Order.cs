using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CookieKitchensGU.Models
{
    public class Order
    {
        //Properties
        [Required]
        [Display(Name ="Order Id")]
        public int OrderId { get; set; }
        [Display(Name ="Order Date")]
        public DateTime OrderDate { get; set; }
        [Required]
        [Display(Name = "Is Complete")]
        public bool IsComplete { get; set; }
        [Required]
        [Display(Name = "Order Total")]
        public decimal OrderTotal { get; set; }

        //Navigational Properties
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer MyProperty { get; set; }

        public List<OrderLine> OrderLines { get; set; }
    }
}